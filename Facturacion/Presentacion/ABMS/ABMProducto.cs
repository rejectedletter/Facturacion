using Facturacion.Dominio;
using Facturacion.Presentacion;
using System;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABMProducto : ABMBase
    {
         
        public Guid _clienteId { get; set; }
        public ABMProducto(TipoOperacion tipoOperacion, Guid clienteId)
        {
            _tipoOperacion = tipoOperacion;
            _clienteId = clienteId;

            InitializeComponent();

            CargarTitulo(_tipoOperacion);

            

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarInput())
            {
                if(_tipoOperacion == TipoOperacion.Alta)
                {
                    AgregarProducto(txtDescripcion.Text, txtPrecio.Text, _clienteId);

                    var msg = MessageBox.Show("Se agregó correctamente", caption: "Producto Agregado");
                    this.Close();
                }

                //if(_tipoOperacion ==TipoOperacion.Modificacion)
                //{
                //    ModificarProducto(txtDescripcion.Text, txtPrecio.Text);

                //    var msg = MessageBox.Show("Se modificó correctamente", caption: "Producto Modificado");
                //    this.Close();
                //}
                
            }
           

            



        }

        //private void ModificarProducto(string descripcion, string precio)
        //{
        //    var objetoModificar = new Producto()
        //    {
        //        Descripcion = descripcion,
        //        PrecioUnitario = decimal.Parse(precio)
        //    };

        //    Aplicacion.ProductoServicio.Modificar(objetoModificar);
        //}

        private void AgregarProducto(string descripcion, string monto, Guid clienteId)
        {
            var objetoAgregar = new Producto()
            {
                Descripcion = descripcion,
                MontoTotalCancelar = decimal.Parse(monto)
            };

            Aplicacion.ProductoServicio.Agregar(objetoAgregar, clienteId);
        }

        private bool ValidarInput()
        {
            throw new NotImplementedException();
        }

        
    }
}
