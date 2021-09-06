
using Microsoft.Reporting.WinForms;
using System;
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

           
            CargarReporte();
            

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

        private void CargarReporte()
        {
            ReportParameter[] reportParams = new ReportParameter[12];

            reportParams[0] = new ReportParameter("fecha", DateTime.Now.ToString());
            reportParams[1] = new ReportParameter("nroCliente", DateTime.Now.ToString());
            reportParams[2] = new ReportParameter("nombreCliente", DateTime.Now.ToString());
            reportParams[3] = new ReportParameter("direccion", DateTime.Now.ToString());
            reportParams[4] = new ReportParameter("compra", DateTime.Now.ToString());
            reportParams[5] = new ReportParameter("pagado", DateTime.Now.ToString());
            reportParams[6] = new ReportParameter("saldo", DateTime.Now.ToString());
            reportParams[7] = new ReportParameter("ultPago", DateTime.Now.ToString());
            reportParams[8] = new ReportParameter("atraso", DateTime.Now.ToString());
            reportParams[9] = new ReportParameter("cantSemanasPlan", DateTime.Now.ToString());
            reportParams[10] = new ReportParameter("alicuotaPlan", DateTime.Now.ToString());
            reportParams[11] = new ReportParameter("fechaEstimadaCancelacion", DateTime.Now.ToString());

            // ReportDataSource rds = new ReportDataSource("DatosFactura", )

            this.rvrFacturacion.LocalReport.ReportEmbeddedResource = "Facturacion.Presentacion.Reportes.FacturaComprobante.rdlc";
            this.rvrFacturacion.LocalReport.DataSources.Clear();
            // this.rvrFacturacion.LocalReport.DataSources.Add(rds);
            this.rvrFacturacion.LocalReport.SetParameters(reportParams);
            this.rvrFacturacion.SetDisplayMode(DisplayMode.PrintLayout);
            this.rvrFacturacion.ZoomMode = ZoomMode.PageWidth;
            this.rvrFacturacion.RefreshReport();
        }
    }
}
