using Facturacion.Aplicacion;
using Facturacion.Dominio.Dto;
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
    public partial class Factura : Form
    {
        private ClienteDto _cliente;
        public Factura(ClienteDto cliente)
        {
            _cliente = cliente;
            InitializeComponent();

            lblNombreCliente.Visible = true;
            lblNroCliente.Visible = true;
            lblNombreCliente.Text = cliente.ApellidoYNombre;
            lblNroCliente.Text = cliente.CodigoCliente;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
