using Facturacion.Aplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ListadoCuentaCliente : Form
    {
        private readonly MovimientoServicio movimientoServicio = new MovimientoServicio();
        private Guid _cuentaCliente;
        public ListadoCuentaCliente(Guid cuentaclienteId)
        {
            _cuentaCliente = cuentaclienteId;

            InitializeComponent();

            ColorConfig();


            //dgvCuentaCliente.Columns.Add("Movimiento", "Movimiento");
            //dgvCuentaCliente.Columns.Add("Fecha", "Fecha");
            //dgvCuentaCliente.Columns.Add("Vencimiento", "Vencimiento");
            //dgvCuentaCliente.Columns.Add("Operación", "Operación");
            //dgvCuentaCliente.Columns.Add("Importe", "Importe");
            //dgvCuentaCliente.Columns.Add("Debe", "Debe");
            //dgvCuentaCliente.Columns.Add("Haber", "Haber");
            //dgvCuentaCliente.Columns.Add("Saldo", "Saldo");

            //var obj = new object[] { "57", "01/01/9999", "01/01/9999", "Recibo de pago", "$1500", "0.00", "1500", "0.00" };

            //_obj = obj;
            
        }

        private void ColorConfig()
        {
            pnlImg.BackColor = (Color)new ColorConverter().ConvertFromString(ColorStatics.orange);
            lblTitulo.ForeColor = (Color)new ColorConverter().ConvertFromString(ColorStatics.bluelight2);
        }

        private void ListadoCuentaCliente_Load(object sender, EventArgs e)
        {
            dgvCuentaCliente.DataSource = movimientoServicio.ListarMovimientos(_cuentaCliente);
            
        }

        private void dgvCuentaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {

        }
    }
}
