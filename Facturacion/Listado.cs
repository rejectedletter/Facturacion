using Facturacion.Dominio;
using Facturacion.Dominio.Entities;
using Facturacion.Helpers;
using System;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Listado : Form
    {
        public int selectedRowIndex { get; set; }

        public Listado()
        {
            InitializeComponent();
            dgvProductos.DataSource = Aplicacion.Servicios.ClienteServicio.Listar(string.Empty);
            FormatearGrilla();
            
        }

        private void FormatearGrilla()
        {
            
            Utils.AgregarColumnas(dgvProductos, new Cliente().ObtenerPropiedades());
            
            
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {


            var formModificar = new ABMCliente(TipoOperacion.Modificacion);
            formModificar.Show();
        }

       

        private void lblAgregarCliente_Click(object sender, EventArgs e)
        {
            var formAgregar = new ABMCliente(TipoOperacion.Alta);
            formAgregar.Show();
        }

       
        private void Listado_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = Aplicacion.Servicios.ClienteServicio.Listar(string.Empty);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void btnAgregarDeuda_Click(object sender, EventArgs e)
        {
            if (btnAgregarDeuda.Pressed == true)
            {
                var formNuevaDeuda = new ABMProducto(TipoOperacion.Alta, (Guid)dgvProductos[0, selectedRowIndex].Value);
                formNuevaDeuda.Show();
            }
        }

        private void btnDetalleCuenta_Click(object sender, EventArgs e)
        {
            var formDetalleCuenta = new ListadoCuentaCliente((Guid)dgvProductos[0, selectedRowIndex].Value);
            formDetalleCuenta.Show();
        }
    }
}
