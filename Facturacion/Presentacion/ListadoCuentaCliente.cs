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
        public object _obj = new object();
        public ListadoCuentaCliente(Guid clienteId)
        {
            InitializeComponent();
            dgvCuentaCliente.Columns.Add("Movimiento", "Movimiento");
            dgvCuentaCliente.Columns.Add("Fecha", "Fecha");
            dgvCuentaCliente.Columns.Add("Vencimiento", "Vencimiento");
            dgvCuentaCliente.Columns.Add("Operación", "Operación");
            dgvCuentaCliente.Columns.Add("Importe", "Importe");
            dgvCuentaCliente.Columns.Add("Debe", "Debe");
            dgvCuentaCliente.Columns.Add("Haber", "Haber");
            dgvCuentaCliente.Columns.Add("Saldo", "Saldo");

            var obj = new object[] { "57", "01/01/9999", "01/01/9999", "Recibo de pago", "$1500", "0.00", "1500", "0.00" };

            _obj = obj;
            
        }

        private void ListadoCuentaCliente_Load(object sender, EventArgs e)
        {
            dgvCuentaCliente.DataSource = _obj;
            
        }

        private void dgvCuentaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
