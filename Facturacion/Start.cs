using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Aplicacion;

namespace Facturacion
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

           
           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnListarDePRoductos_Click(object sender, EventArgs e)
        {
            var formListarProductos = new Listado();
            formListarProductos.Show();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var formAgregarProducto = new ABMProducto(TipoOperacion.Alta, (Guid)sender);
            formAgregarProducto.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
