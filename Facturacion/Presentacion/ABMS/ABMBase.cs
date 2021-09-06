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
    public partial class ABMBase : Form
    {
        protected TipoOperacion _tipoOperacion;
        
        public ABMBase()
        {
            
            
            InitializeComponent();

            CargarTitulo(_tipoOperacion);
        }

        protected virtual void CargarTitulo(TipoOperacion tp)
        {
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.AutoSize = true;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RealizarOperacion();
        }

        protected virtual void RealizarOperacion()
        {
            
        }
    }
}
