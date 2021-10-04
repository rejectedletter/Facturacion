using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Dto;
using Facturacion.Helpers;
using Facturacion.Presentacion;
using Facturacion.Reportes;

namespace Facturacion
{
    public partial class Start : PresentacionBase
    {
        Type tipoAccion;
        public int selectedRowIndex { get; set; }
        
        private readonly ClienteServicio _clienteServicio = new ClienteServicio();
        private readonly ZonaServicio _zonaServicio = new ZonaServicio();
        private readonly PlanServicio _planServicio = new PlanServicio();
        public Start()
        {
            InitializeComponent();

            

            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnCuentaCliente.Visible = false;
           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            
        }

        

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            tipoAccion = typeof(ClienteDto);

            CargarClientes();
            
        }

        

        private void CargarClientes()
        {
           dgvDatos.DataSource = new ClienteServicio().Listar(string.Empty);

           new DgvFormatting().FormatCliente(ref dgvDatos);

            btnNuevo.Visible = true;
            btnModificar.Visible = true;
            btnCuentaCliente.Visible = true;
            btnEliminar.Visible = false;

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

       
       

        private void CargarZonas()
        {
            dgvDatos.DataSource = _zonaServicio.ListarZonas();

            DgvFormatting.FormatZona(ref dgvDatos);

            btnNuevo.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = true;
            btnCuentaCliente.Visible = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            tipoAccion = typeof(PlanDto);

            CargarPlanes();
        }

        private void CargarPlanes()
        {
            dgvDatos.DataSource = _planServicio.ListarPlanes();

            DgvFormatting.FormatPlan(ref dgvDatos);

            btnNuevo.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = true;
            btnCuentaCliente.Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var formNuevo = TriggerAbm.ABMTrigger(tipoAccion, TipoOperacion.Alta);
            formNuevo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var formNuevo = TriggerAbm.ABMTrigger(tipoAccion, TipoOperacion.Modificacion, (Guid)dgvDatos[0, selectedRowIndex].Value);
            formNuevo.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tipoAccion == typeof(ZonaDto))
            {
                var eliminar = _zonaServicio.EliminarZona((Guid)dgvDatos[0, selectedRowIndex].Value);
                if (eliminar)
                {
                    MessageBox.Show("Se eliminó la zona correctamente", "Eliminar Zona", MessageBoxButtons.OK);

                }
            }

            if (tipoAccion == typeof(PlanDto))
            {
                var eliminar = _planServicio.EliminarPlan((Guid)dgvDatos[0, selectedRowIndex].Value);
                if (eliminar)
                {
                    MessageBox.Show("Se eliminó el plan correctamente", "Eliminar Plan", MessageBoxButtons.OK);

                }
            }

        }

        private void btnComprobante_Click(object sender, EventArgs e) { 
            /*var comprobante = new FacturaComprobante(new List<FacturaDto>(){new FacturaDto
            {

            } });
            comprobante.Show();*/
        }

        private void btnCuentaCliente_Click(object sender, EventArgs e)
        {
            var formCuenta = new ListadoCuentaCliente((Guid)dgvDatos["CuentaclienteId", selectedRowIndex].Value);
            formCuenta.Show();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            //ReporteFactura frm = new ReporteFactura();
            //frm.ShowDialog();
        }

        

        private void btnClientes_Click(object sender, EventArgs e)
        {
            tipoAccion = typeof(ClienteDto);

            CargarClientes();
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            tipoAccion = typeof(ZonaDto);

            CargarZonas();
        }
    }
}
