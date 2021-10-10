using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Dto;
using Facturacion.Infraestructura;
using Facturacion.Infraestructura.Diagram;
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
        private Producto _producto = null;

        private readonly ZonaServicio _zonaServicio = new ZonaServicio();

        private List<Zona> Zonas => _zonaServicio.ListarZonas();
        public ABMCliente(TipoOperacion tipoOperacion, Guid? id)
         {

            _tipoOperacion = tipoOperacion;
            _id = id;
           
            
            InitializeComponent();

            lblCodigocliente.Visible = false;
            btnAceptar.BringToFront();

           CargarTitulo(tipoOperacion);
         }

        private void CargarCombo()
        {
            if (Zonas.Count < 1 || Zonas == null)
            {
                MessageBox.Show("Por favor, primero cargar Zonas", "Sin zonas cargadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
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
            CargarCombo();

            if (_tipoOperacion == TipoOperacion.Modificacion)
            {
                CargarDatosCliente(_id);
                btnCargarProducto.Visible = false;
            }
        }

        private void CargarDatosCliente(Guid? id)
        {
            var cliente = _clienteServicio.GetCliente((Guid)id);
            txtApellido.Text = cliente.Apellido;
            txtCelular.Text = cliente.NroCelular;
            txtDni.Text = cliente.DNI;
           // txtNombre.Text = cliente.Nombre;
            txtRubro.Text = cliente.Rubro;
            txttelefono.Text = cliente.TelefonoFijo;
            
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
                    Dni = txtDni.Text,
                    FechaNacimiento = dTPFechaNac.Value,
                    DomicilioParticular = txtDirParticular.Text + txtBarrioParticular.Text + txtLocParticular.Text,
                    

                    DomicilioComercial =  txtDirComercial.Text + txtBarrioComercial.Text + txtBarrioComercial.Text,
                    
                    NroCelular = txtCelular.Text,
                    TelefonoFijo = txttelefono.Text,
                    Rubro = txtRubro.Text,
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

            if (_tipoOperacion == TipoOperacion.Modificacion)
            {
               
                
                var nuevoCliente = new ClienteDto()
                {
                    ClienteId = (Guid)_id,
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text,
                    Dni = txtDni.Text,
                    FechaNacimiento = dTPFechaNac.Value,
                    DomicilioParticular = txtDirParticular.Text + txtBarrioParticular.Text + txtLocParticular.Text,


                    DomicilioComercial = txtDirComercial.Text + txtBarrioComercial.Text + txtBarrioComercial.Text,

                    NroCelular = txtCelular.Text,
                    TelefonoFijo = txttelefono.Text,
                    Rubro = txtRubro.Text,
                    Zona = Zonas.First(x => x.NombreZona == cmbZona.SelectedItem.ToString())
                };



                


                var agregado = _clienteServicio.Modificar(nuevoCliente);
                if (agregado)
                {
                    MessageBox.Show("Se modificó correctamente", "Modificar Cliente", MessageBoxButtons.OK);
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
