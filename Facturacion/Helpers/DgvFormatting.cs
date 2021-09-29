using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Facturacion.Helpers
{
    public  class DgvFormatting
    {
        public TablesConfig Data;
        public Dictionary<string, string> ClientesColumns;
        public Dictionary<string, string> CuentasColumns;
        public DgvFormatting()
        {
            using (StreamReader r = new StreamReader(
                @"Helpers/TablesConfig.json"))
            {
                string json = r.ReadToEnd();
                Data = JsonConvert.DeserializeObject<TablesConfig>(json);
            }

            ClientesColumns = Data.Clientes;
            CuentasColumns = Data.CuentaClientes;
        }
        public  void FormatCliente(ref DataGridView dgvCliente)
        {
           
            //foreach (DataGridViewColumn col in dgvCliente.Columns)
            //{
            //    col.Visible = false;
            //}

            foreach (var column in ClientesColumns)
            {
                dgvCliente.Columns[column.Key].Visible = true;
                dgvCliente.Columns[column.Key].HeaderText = column.Value;
            }
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
    public class TablesConfig
    {
        public Dictionary<string, string> Clientes;
        public Dictionary<string, string> CuentaClientes;
    }
}
