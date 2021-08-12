using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Entities;
using System;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABMCliente : Form
    {

        public TipoOperacion _tipoOperacion { get; set; }
    public ABMCliente(TipoOperacion tipoOperacion)
        {
            _tipoOperacion = tipoOperacion;

           
            
            InitializeComponent();

            lblCodigocliente.Visible = false;

            if (_tipoOperacion == TipoOperacion.Modificacion)
            {
                //precargar datos
                lblTitulo.Text = "Modificar datos del cliente";
            }

            if (_tipoOperacion == TipoOperacion.Alta)
            {
                //precargar datos
                lblTitulo.Text = "Agregar nuevo cliente";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_tipoOperacion == TipoOperacion.Alta)
            {
                var nuevoCliente = new Cliente()
                {
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text,
                    Direccion = txtdireccion.Text
                };

                ClienteServicio.Agregar(nuevoCliente);

                lblCodigocliente.Visible = true;
                lblCodigocliente.Text = nuevoCliente.CodigoCliente;
            }
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
