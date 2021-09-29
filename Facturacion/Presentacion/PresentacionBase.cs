using Facturacion.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Presentacion
{
    public partial class PresentacionBase : Form
    {
        public PresentacionBase()
        {
            InitializeComponent();

            pnlImg.BackColor = (Color)new ColorConverter().ConvertFromString(ColorStatics.orange);

            //btnCerrar.BackgroundImage = ImageStatics.close;

            //CargarImagenes();
            
        }

        private void CargarImagenes()
        {
            throw new NotImplementedException();
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

        private void PresentacionBase_Load(object sender, EventArgs e)
        {

        }
    }
}
