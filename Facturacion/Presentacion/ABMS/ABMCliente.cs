using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Dto;
using Facturacion.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABMCliente : ABMBase
    {
        private readonly ClienteServicio _clienteServicio = new ClienteServicio();
        private ProductoDto _producto = null;

        private readonly ZonaServicio _zonaServicio = new ZonaServicio();

        private List<ZonaDto> Zonas => _zonaServicio.ListarZonas();
        public ABMCliente(TipoOperacion tipoOperacion)
         {

            _tipoOperacion = tipoOperacion;

            InitializeComponent();
            lblCodigocliente.Visible = false;
            btnAceptar.BringToFront();

            CargarCombo();
            CargarTitulo(tipoOperacion);
         }

        private void CargarCombo()
        {
            cmbZona.DataSource = Zonas.Select(x => x.NombreZona).ToList();
        }

        protected override void CargarTitulo(TipoOperacion tp)
        {
           

            if (tp == TipoOperacion.Modificacion)
            {
                //precargar datos
                lblTitulo.Text = "Modificar datos del cliente";
            }

            if (tp == TipoOperacion.Alta)
            {
                //precargar datos
                lblTitulo.Text = "Nuevo Cliente";
            }
        }

       

        private void ABMCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Validaciones.LetrasYNumeros(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Validaciones.LetrasYNumeros(e);
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Validaciones.LetrasYNumeros(e);
        }

        protected override void RealizarOperacion()
        {
            if (_tipoOperacion == TipoOperacion.Alta)
            {
                var nuevoCliente = new ClienteDto()
                {
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text,
                    FechaNacimiento = dTPFechaNac.Value,
                    Zona = Zonas.First(x => x.NombreZona == cmbZona.SelectedItem.ToString())
                };



                lblCodigocliente.Visible = true;
                lblCodigocliente.Text = nuevoCliente.CodigoCliente;
            

              var agregado =_clienteServicio.Agregar(nuevoCliente, _producto);
                if (agregado)
                {
                    MessageBox.Show("Se agregó correctamente", "Agregar Cliente", MessageBoxButtons.OK);
                    Close();
                }
            }
        }

       

        private void btnCargarProducto_Click_1(object sender, EventArgs e)
        {
            var formProducto = new ABMProducto(TipoOperacion.Alta, null);
            formProducto.ShowDialog();
            _producto = formProducto.Producto;
        }

        private void pnlcliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
