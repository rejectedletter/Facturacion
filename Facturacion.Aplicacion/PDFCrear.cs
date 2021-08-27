using Facturacion.Dominio.Dto;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.Linq;

namespace Facturacion.Aplicacion
{
    public class PDFCrear
    {
         private const double ContainerMarginTop = 10;

        private const double HeightRatioContainers =  4;


        public static void Crear(FacturaDto factura)
        {
            var document = new PdfDocument();
            document.Info.Title = string.Concat(factura.DetalleCliente.Cliente.ApellidoYNombre.Trim(), DateTime.Now.ToString("ddMMyyyyhhmm"));

            var page = document.AddPage();

           XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont fontTitle = new XFont("Verdana", 7, XFontStyle.BoldItalic);
            XFont font = new XFont("Verdana", 7, XFontStyle.Regular);

            var leftContainer = new XRect(10, 10, page.Width/3, page.Height / 4);
            var rightContainer = new XRect(220, 10, page.Width * 0.6, page.Height / 4);

            gfx.DrawRectangle(new XPen(XColor.Empty),
               leftContainer);
            gfx.DrawRectangle(new XPen(XColor.Empty),
               rightContainer);

            CrearFacturaVendedor(gfx, factura, font, leftContainer);
            CrearFacturaCliente(gfx, factura, font, rightContainer);
            //gfx.DrawLine(new XPen(XColor.FromName("Black"), 1), 10, 100, -10, 100);



            //gfx.DrawString("Cliente: " + factura.DetalleCliente.Cliente.CodigoCliente, font, XBrushes.Black,
            //   new XRect(20, 20, container.Width, container.Height),
            //   XStringFormats.TopLeft);

            //gfx.DrawString(factura.DetalleCliente.Cliente.ApellidoYNombre, font, XBrushes.Black,
            //   new XRect(20, 30, container.Width, container.Height),
            //   XStringFormats.TopLeft);

            //gfx.DrawString(factura.DetalleCliente.Cliente.Direccion, font, XBrushes.Black,
            //   new XRect(20, 40, container.Width, container.Height),
            //   XStringFormats.TopLeft);

            ////gfx.DrawString("Compra: " + factura.DetalleProducto.DetalleProducto.Descripcion, font, XBrushes.Black,
            ////   new XRect(20, 40, container.Width, container.Height),
            ////   XStringFormats.CenterLeft);

            //gfx.DrawString("Pago: " + factura.Monto.ToString(), font, XBrushes.Black,
            //   new XRect(20, 60, container.Width, container.Height),
            //   XStringFormats.TopLeft);
            //gfx.DrawString("Compra: " + factura.DetalleProducto.DetalleProducto.MontoTotalCancelar.ToString(), font, XBrushes.Black,
            //   new XRect(20, 70, container.Width, container.Height),
            //   XStringFormats.TopLeft);
            //gfx.DrawString("Pagado: " + factura.DetalleCliente.Cliente.CuentaCliente.Haber.ToString(), font, XBrushes.Black,
            //   new XRect(20, 80, container.Width, container.Height),
            //   XStringFormats.TopLeft);

            //gfx.DrawString("Saldo: " + factura.DetalleCliente.Cliente.CuentaCliente.Debe.ToString(), font, XBrushes.Black,
            //   new XRect(20, 90, container.Width, container.Height),
            //   XStringFormats.TopLeft);

            //gfx.DrawString("Ult. Pago: " + factura.DetalleCliente.Cliente.CuentaCliente.Movimientos.First().FechaMovimiento.ToString(), font, XBrushes.Black,
            //   new XRect(20, 100, container.Width, container.Height),
            //   XStringFormats.TopLeft);

            //gfx.DrawString("Atraso: " + "$610", font, XBrushes.Black,
            //   new XRect(20, 110, container.Width, container.Height),
            //  XStringFormats.TopLeft);

            //gfx.DrawString("Fecha: " + factura.Fecha.ToString(), font, XBrushes.Black,
            //   new XRect(0, 20, container.Width, container.Height),
            //  XStringFormats.TopCenter);

            //gfx.DrawRectangle(new XPen(XColor.Empty),
            //   new XRect(10, 200, 900, page.Height / 6));

            //gfx.DrawString("Pago: " + factura.Monto.ToString(), font, XBrushes.Black,
            //  new XRect(20, 220, container.Width, container.Height/6),
            //  XStringFormats.CenterLeft);
            //gfx.DrawString("Compra: " + factura.DetalleProducto.DetalleProducto.MontoTotalCancelar.ToString(), font, XBrushes.Black,
            //   new XRect(20, 230, container.Width, container.Height/6),
            //   XStringFormats.CenterLeft);
            //gfx.DrawString("Pagado: " + factura.DetalleCliente.Cliente.CuentaCliente.Haber.ToString(), font, XBrushes.Black,
            //   new XRect(20, 240, container.Width, container.Height/6),
            //   XStringFormats.CenterLeft);

            //gfx.DrawString("Saldo: " + factura.DetalleCliente.Cliente.CuentaCliente.Debe.ToString(), font, XBrushes.Black,
            //   new XRect(20, 250, container.Width, container.Height/6),
            //   XStringFormats.CenterLeft);

            //gfx.DrawString("Ult. Pago: " + factura.DetalleCliente.Cliente.CuentaCliente.Movimientos.First().FechaMovimiento.ToString(), font, XBrushes.Black,
            //   new XRect(20, 260, container.Width, container.Height/6),
            //   XStringFormats.CenterLeft);

            //gfx.DrawString("Atraso: " + "$610", font, XBrushes.Black,
            //   new XRect(20, 270, container.Width, container.Height/6),
            //  XStringFormats.CenterLeft);

            //gfx.DrawString("Fecha: " + factura.Fecha.ToString(), font, XBrushes.Black,
            //   new XRect(20, 200,800, container.Height/6 ),
            //  XStringFormats.Center);

            string filename = @"C:\Users\Public\Documents\" + document.Info.Title + ".pdf";

            document.Save(filename);

            Process.Start(filename);
        }

        private static void CrearFacturaCliente(XGraphics gfx, FacturaDto factura, XFont font, XRect container)
        {
            gfx.DrawString("Pago: " + factura.Monto.ToString(), font, XBrushes.Black,
              new XRect(20, 220, container.Width, container.Height),
              XStringFormats.CenterLeft);
            gfx.DrawString("Compra: " + factura.DetalleProducto.DetalleProducto.MontoTotalCancelar.ToString(), font, XBrushes.Black,
               new XRect(20, 230, container.Width, container.Height),
               XStringFormats.CenterLeft);
            gfx.DrawString("Pagado: " + factura.DetalleCliente.Cliente.CuentaCliente.Haber.ToString(), font, XBrushes.Black,
               new XRect(20, 240, container.Width, container.Height),
               XStringFormats.CenterLeft);

            gfx.DrawString("Saldo: " + factura.DetalleCliente.Cliente.CuentaCliente.Debe.ToString(), font, XBrushes.Black,
               new XRect(20, 250, container.Width, container.Height),
               XStringFormats.CenterLeft);

            gfx.DrawString("Ult. Pago: " + factura.DetalleCliente.Cliente.CuentaCliente.Movimientos.First().FechaMovimiento.ToString(), font, XBrushes.Black,
               new XRect(20, 260, container.Width, container.Height),
               XStringFormats.CenterLeft);

            gfx.DrawString("Atraso: " + "$610", font, XBrushes.Black,
               new XRect(20, 270, container.Width, container.Height),
              XStringFormats.CenterLeft);

            gfx.DrawString("Fecha: " + factura.Fecha.ToString(), font, XBrushes.Black,
               new XRect(20, 200, 800, container.Height),
              XStringFormats.Center);
        }

        private static void CrearFacturaVendedor(XGraphics gfx, FacturaDto factura, XFont font,  XRect container)
        {
            gfx.DrawString("Cliente: " + factura.DetalleCliente.Cliente.CodigoCliente,font, XBrushes.Black,
               new XRect(20, 20, container.Width, container.Height),
               XStringFormats.TopLeft);

            gfx.DrawString(factura.DetalleCliente.Cliente.ApellidoYNombre, font, XBrushes.Black,
               new XRect(20, 30, container.Width, container.Height),
               XStringFormats.TopLeft);

            gfx.DrawString(factura.DetalleCliente.Cliente.Direccion, font, XBrushes.Black,
               new XRect(20, 40, container.Width, container.Height),
               XStringFormats.TopLeft);

            gfx.DrawString("Compra: " + factura.DetalleProducto.DetalleProducto.Descripcion, font, XBrushes.Black,
               new XRect(20, 40, container.Width, container.Height),
               XStringFormats.CenterLeft);

            gfx.DrawString("Pago: " + factura.Monto.ToString(), font, XBrushes.Black,
               new XRect(20, 60, container.Width, container.Height),
               XStringFormats.TopLeft);
            gfx.DrawString("Compra: " + factura.DetalleProducto.DetalleProducto.MontoTotalCancelar.ToString(), font, XBrushes.Black,
               new XRect(20, 70, container.Width, container.Height),
               XStringFormats.TopLeft);
            gfx.DrawString("Pagado: " + factura.DetalleCliente.Cliente.CuentaCliente.Haber.ToString(), font, XBrushes.Black,
               new XRect(20, 80, container.Width, container.Height),
               XStringFormats.TopLeft);

            gfx.DrawString("Saldo: " + factura.DetalleCliente.Cliente.CuentaCliente.Debe.ToString(), font, XBrushes.Black,
               new XRect(20, 90, container.Width, container.Height),
               XStringFormats.TopLeft);

            gfx.DrawString("Ult. Pago: " + factura.DetalleCliente.Cliente.CuentaCliente.Movimientos.First().FechaMovimiento.ToString(), font, XBrushes.Black,
               new XRect(20, 100, container.Width, container.Height),
               XStringFormats.TopLeft);

            gfx.DrawString("Atraso: " + "$610", font, XBrushes.Black,
               new XRect(20, 110, container.Width, container.Height),
              XStringFormats.TopLeft);

            gfx.DrawString("Fecha: " + factura.Fecha.ToString(), font, XBrushes.Black,
               new XRect(0, 20, container.Width, container.Height),
              XStringFormats.TopCenter);
        }
    }
}
