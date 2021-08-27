using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Reportes
{
    public partial class FacturaComprobante : Form
    {
        public FacturaComprobante()
        {
            InitializeComponent();
        }

        private void FacturaComprobante_Load(object sender, EventArgs e)
        {

            this.rvrFacturacion.RefreshReport();

            

            //Ejemplo de agregado de parametros

            //ReportParameter[] param = new ReportParameter[1];

            //if (!string.IsNullOrEmpty(DatosConfiguracion.PathLogo))
            //{
            //    param[0] = new ReportParameter("Imagen", new Uri(DatosConfiguracion.PathLogo).AbsoluteUri);
            //}
            //else
            //{
            //    param[0] = new ReportParameter("Imagen", "");
            //}

            //setear datos y enlazzar componente y reporte

            //ReportDataSource rds1 = new ReportDataSource("InformeConsolidado", lInformeConsolidado);
            //repViewInformeConsolidado.LocalReport.ReportEmbeddedResource = "UI.Desktop.Reportes.RInformeConsolidado.rdlc";
            //repViewInformeConsolidado.LocalReport.EnableExternalImages = true;
            //repViewInformeConsolidado.LocalReport.SetParameters(param);
            //repViewInformeConsolidado.LocalReport.DataSources.Clear();
            //repViewInformeConsolidado.LocalReport.DataSources.Add(rds1);
            //repViewInformeConsolidado.SetDisplayMode(DisplayMode.PrintLayout);
            //repViewInformeConsolidado.ZoomMode = ZoomMode.PageWidth;
            //repViewInformeConsolidado.RefreshReport();


        }
    }
}
