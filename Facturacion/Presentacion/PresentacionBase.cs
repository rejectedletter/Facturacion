using Facturacion.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Presentacion
{
    public partial class PresentacionBase : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        public PresentacionBase()
        {
            InitializeComponent();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

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
            CloseForm();
        }

        protected virtual void CloseForm()
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || 
                WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal ||
                WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

            //this.WindowState = FormWindowState.Minimized;
        }

        private void PresentacionBase_Load(object sender, EventArgs e)
        {

        }

        private void pnlImg_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }
    }
}
