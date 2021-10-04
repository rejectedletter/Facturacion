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
    public partial class ABMBase : PresentacionBase
    {
        protected TipoOperacion _tipoOperacion;
        protected Guid? _id;
        public ABMBase()
        {
            
            
            InitializeComponent();
            btnAceptar.Visible = true;
            btnAceptar.BringToFront();

            CargarTitulo(_tipoOperacion);
        }

        protected virtual void CargarTitulo(TipoOperacion tp)
        {
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.AutoSize = true;
            
        }

        

        protected virtual void RealizarOperacion()
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RealizarOperacion();
        }
        protected override void CloseForm()
        {
            this.Close();
        }
    }
}
