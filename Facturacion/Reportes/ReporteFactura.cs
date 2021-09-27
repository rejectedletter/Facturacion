using Facturacion.Aplicacion.Servicios;
using Facturacion.Dominio.Dto;
using Microsoft.Reporting.WinForms;
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
    public partial class ReporteFactura : Form
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

        public ReporteFactura(string dniCliente = "42350914")
        {
            InitializeComponent();


            DniCliente = dniCliente;
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

            //this.rvrFacturacion.LocalReport.ReportEmbeddedResource = @"Facturacion\Reportes\JoelReporte.rdlc";
            this.rvrFacturacion.SetDisplayMode(DisplayMode.PrintLayout);
            this.rvrFacturacion.LocalReport.SetParameters(reportParams);
            this.rvrFacturacion.ZoomMode = ZoomMode.PageWidth;
            this.rvrFacturacion.RefreshReport();
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
