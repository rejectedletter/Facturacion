
using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Dto;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facturacion.Reportes
{
    public partial class FacturaComprobante : Form
    {
        FacturaServicio servicio = new FacturaServicio();
        public string DniCliente { get; set; }

        private readonly IEnumerable<FacturaDto> _factura;
        /*public FacturaComprobante(IEnumerable<FacturaDto> factura, string dniCliente = "39975846")
        {
            InitializeComponent();


            DniCliente = dniCliente;
            _factura = factura;
        }*/

        public FacturaComprobante(string dniCliente = "39975846")
        {
            InitializeComponent();


            DniCliente = dniCliente;
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
            List<InformeFacturacionDto> lInforme = servicio.GetInformeFacturacion(DniCliente);

            ReportParameter[] reportParams = new ReportParameter[4];

            //ReportDataSource rds = new ReportDataSource("DatosFactura", _factura);

            reportParams[0] = new ReportParameter("fecha", lInforme.First().Nombre);
            reportParams[1] = new ReportParameter("nroCliente", lInforme.First().Apellido);
            reportParams[2] = new ReportParameter("nombreCliente", lInforme.First().Dni);
            reportParams[3] = new ReportParameter("direccion", lInforme.First().Debe.ToString());
            /*reportParams[4] = new ReportParameter("compra", DateTime.Now.ToString());
            reportParams[5] = new ReportParameter("pagado", DateTime.Now.ToString());
            reportParams[6] = new ReportParameter("saldo", DateTime.Now.ToString());
            reportParams[7] = new ReportParameter("ultPago", DateTime.Now.ToString());
            reportParams[8] = new ReportParameter("atraso", DateTime.Now.ToString());
            reportParams[9] = new ReportParameter("cantSemanasPlan", DateTime.Now.ToString());
            reportParams[10] = new ReportParameter("alicuotaPlan", DateTime.Now.ToString());
            reportParams[11] = new ReportParameter("fechaEstimadaCancelacion", DateTime.Now.ToString());*/

            //ReportDataSource rds = new ReportDataSource("DatosFactura", _factura);

            //this.rvrFacturacion.LocalReport.ReportEmbeddedResource = "UI.Desktop.Reportes.RInformeTrazabilidadPorPallet.rdlc";
            this.rvrFacturacion.LocalReport.SetParameters(reportParams);
            this.rvrFacturacion.SetDisplayMode(DisplayMode.PrintLayout);
            this.rvrFacturacion.ZoomMode = ZoomMode.PageWidth;
            this.rvrFacturacion.RefreshReport();
        }
    }
}
