using Facturacion.Dominio;
using System;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
            dgvProductos.DataSource = Aplicacion.ProductoServicio.Listar(string.Empty);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {


            var formModificar = new ABM(TipoOperacion.Modificacion, Guid.Parse(dgvProductos.SelectedRows[0].Cells[0].Value.ToString()));
            formModificar.Show();
        }
    }
}
