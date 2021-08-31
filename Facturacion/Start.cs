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
using Facturacion.Aplicacion.Servicios;

namespace Facturacion
{
    public partial class Start : Form
    {
        ClienteServicio _clienteServicio = new ClienteServicio();
        ZonaServicio zonaServicio = new ZonaServicio();
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
            CargarClientes();
            
        }

        

        private void CargarClientes()
        {
            dgvDatos.DataSource = ClienteServicio.Listar(string.Empty);
;        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarZonas();
        }

        private void CargarZonas()
        {
            dgvDatos.DataSource = zonaServicio.ListarZonas();
            
            btnNuevo.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            CargarPlanes();
        }

        private void CargarPlanes()
        {
            dgvDatos.DataSource = PlanServicio.Listar();

            btnNuevo.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
        }
    }
}
