using System.Collections.Generic;
using System.Windows.Forms;

namespace Facturacion.Helpers
{
    public static class DgvFormatting
    {
      public static void FormatCliente(ref DataGridView dgvCliente)
        {
            dgvCliente.Columns["NroCliente"].HeaderText = "Nro. cliente";
            dgvCliente.Columns["CodigoCliente"].HeaderText = "Codigo Cliente";
            dgvCliente.Columns["ApellidoyNombre"].HeaderText = "Apellido y Nombre";
            dgvCliente.Columns["Direccion"].HeaderText = "Direccion";
            dgvCliente.Columns["NombreZona"].HeaderText = "Zona";
            dgvCliente.Columns["MontoTotalCancelar"].HeaderText = "Compra";
        }

        public static void FormatZona(ref DataGridView dgvCliente)
        {
            dgvCliente.Columns["ZonaId"].Visible = false;

            dgvCliente.Columns["NombreZona"].HeaderText = "Zona";

        }

        public static void FormatPlan(ref DataGridView dgvPlan)
        {
            dgvPlan.Columns["PlanId"].Visible = false;

            dgvPlan.Columns["CantidadCuotas"].HeaderText = "Cantidad de Cuotas";
        }
    }
}
