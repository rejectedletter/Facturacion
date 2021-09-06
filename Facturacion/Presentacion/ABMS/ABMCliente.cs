using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Presentacion;
using System;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABMCliente : ABMBase
    {
         public ABMCliente(TipoOperacion tipoOperacion)
         {
           
            InitializeComponent();
            lblCodigocliente.Visible = false;

            CargarTitulo(tipoOperacion);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_tipoOperacion == TipoOperacion.Alta)
            {
                var nuevoCliente = new ClienteDto()
                {
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text,
                    Direccion = txtdireccion.Text
                };

                

                lblCodigocliente.Visible = true;
                lblCodigocliente.Text = nuevoCliente.CodigoCliente;
            }
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
