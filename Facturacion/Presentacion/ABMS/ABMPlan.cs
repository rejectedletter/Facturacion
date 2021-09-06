using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Dto;
using Facturacion.Presentacion;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABMPlan : ABMBase
    {
        private readonly PlanServicio _planServicio = new PlanServicio();
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

        protected override void RealizarOperacion()
        {
           var agregar = _planServicio.Agregar(new PlanDto()
            {
                Nombre = txtNombre.Text,
                CantidadCuotas = int.Parse(txtCantidadCuotas.Text),
                Porcentaje = int.Parse(txtProcentaje.Text) / 100
            });

            if (agregar)
            {
                MessageBox.Show("Se agregó plan correctamente.", "Nuevo Plan", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
