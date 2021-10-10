using Facturacion.Dominio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Listado : Form
    {
        public int selectedRowIndex { get; set; }
        public List<ClienteDto> clientes;
        public Listado()
        {
           // clientes = Aplicacion.Servicios.ClienteServicio.Listar(string.Empty);

            InitializeComponent();
            dgvProductos.DataSource = clientes;
            //FormatearGrilla();
            
        }

        private void FormatearGrilla()
        {
            
            
            
            
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {


            var formModificar = new ABMCliente(TipoOperacion.Modificacion, (Guid)dgvProductos[0, selectedRowIndex].Value);
            formModificar.Show();
        }

       

        private void lblAgregarCliente_Click(object sender, EventArgs e)
        {
            var formAgregar = new ABMCliente(TipoOperacion.Alta, (Guid)dgvProductos[0, selectedRowIndex].Value);
            formAgregar.Show();
        }

       
        private void Listado_Load(object sender, EventArgs e)
        {
            
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
                var formNuevaDeuda = new ABMProducto(TipoOperacion.Alta, (Guid?)dgvProductos[0, selectedRowIndex].Value);
                formNuevaDeuda.Show();
            }
        }

        private void btnDetalleCuenta_Click(object sender, EventArgs e)
        {
            var formDetalleCuenta = new ListadoCuentaCliente((Guid)dgvProductos[0, selectedRowIndex].Value);
            formDetalleCuenta.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var comprobante = new Factura(clientes.First());
            comprobante.Show();
        }
    }
}
