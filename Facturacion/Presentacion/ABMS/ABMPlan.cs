using Facturacion.Presentacion;

namespace Facturacion
{
    public partial class ABMPlan : ABMBase
    {
        public ABMPlan(TipoOperacion tipoOperacion)
        {
            InitializeComponent();


        }

        protected override void CargarTitulo(TipoOperacion tp)
        {
            if (tp == TipoOperacion.Alta)
            {
                lblTitulo.Text = "Nuevo Plan";
            }
        }
    }
}
