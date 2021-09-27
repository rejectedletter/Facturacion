using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio;
using Facturacion.Dominio.Dto;
using Facturacion.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABMProducto : ABMBase
    {
        public ProductoDto Producto = new ProductoDto();

        private readonly PlanServicio _planServicio = new PlanServicio();

        private  List<PlanDto> Planes => _planServicio.ListarPlanes();
        public ABMProducto(TipoOperacion tipoOperacion, Guid? id)
        {
            _tipoOperacion = tipoOperacion;
           

            InitializeComponent();

            btnAceptar.BringToFront();

            CargarTitulo(_tipoOperacion);
            CargarComboPlanes();
            btnAceptar.BringToFront();
            

        }

        private void CargarComboPlanes()
        {
            cmbPlanes.DataSource = Planes.Select(x=>x.NombrePlan).ToList();
        }



        //private void CargarInformacionProducto(Guid id)
        //{
        //    var objetoCargar = Aplicacion.ProductoServicio..BuscarPorId(id);

        //    txtDescripcion.Text = objetoCargar.Descripcion;
        //    txtPrecio.Text = objetoCargar.PrecioUnitario.ToString();
        //}

        protected override void CargarTitulo(TipoOperacion tp)
        {
            //if (_tipoOperacion == TipoOperacion.Modificacion)
            //{
            //    CargarInformacionProducto(clienteId);
            //    lblTitulo.Text = "Modificar Producto";

            //}

            if (_tipoOperacion == TipoOperacion.Alta)
            {

                lblTitulo.Text = "Nuevo Producto";
            }
        }

        private void ABM_Load(object sender, EventArgs e)
        {

        }

        

        protected override void RealizarOperacion()
        {
            if (_tipoOperacion == TipoOperacion.Alta)
            {


                Producto.Descripcion = txtDescripcion.Text;
                    Producto.MontoTotalCancelar = decimal.Parse(txtPrecio.Text);
                    Producto.Planes = new List<PlanDto>() { Planes.First(x => x.NombrePlan == cmbPlanes.SelectedItem.ToString()) };
                

                var msg = MessageBox.Show("Se agregó correctamente", caption: "Producto Agregado");
                this.Close();
            }
        }

        private bool ValidarInput()
        {
            throw new NotImplementedException();
        }

        
    }
}
