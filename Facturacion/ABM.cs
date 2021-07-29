using Facturacion.Dominio;
using System;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABM : Form
    {
         public TipoOperacion _tipoOperacion { get; set; }
        public ABM(TipoOperacion tipoOperacion, Guid? id)
        {
            _tipoOperacion = tipoOperacion;

            InitializeComponent();

            if (_tipoOperacion == TipoOperacion.Modificacion)
            {
                CargarInformacionProducto((Guid)id);
                lblTitulo.Text = "Modificar Producto";
            }

            if (_tipoOperacion == TipoOperacion.Alta)
            {
                
                lblTitulo.Text = "Agregar Producto";
            }

        }

        private void CargarInformacionProducto(Guid id)
        {
            var objetoCargar = Aplicacion.ProductoServicio.BuscarPorId(id);

            txtDescripcion.Text = objetoCargar.Descripcion;
            txtPrecio.Text = objetoCargar.PrecioUnitario.ToString();
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
                    AgregarProducto(txtDescripcion.Text, txtPrecio.Text);

                    var msg = MessageBox.Show("Se agregó correctamente", caption: "Producto Agregado");
                    this.Close();
                }

                if(_tipoOperacion ==TipoOperacion.Modificacion)
                {
                    ModificarProducto(txtDescripcion.Text, txtPrecio.Text);

                    var msg = MessageBox.Show("Se modificó correctamente", caption: "Producto Modificado");
                    this.Close();
                }
                
            }
           

            



        }

        private void ModificarProducto(string descripcion, string precio)
        {
            var objetoModificar = new Producto()
            {
                Descripcion = descripcion,
                PrecioUnitario = decimal.Parse(precio)
            };

            Aplicacion.ProductoServicio.Modificar(objetoModificar);
        }

        private void AgregarProducto(string descripcion, string precio)
        {
            var objetoAgregar = new Producto()
            {
                Descripcion = descripcion,
                PrecioUnitario = decimal.Parse(precio)
            };

            Aplicacion.ProductoServicio.Agregar(objetoAgregar);
        }

        private bool ValidarInput()
        {
            throw new NotImplementedException();
        }
    }
}
