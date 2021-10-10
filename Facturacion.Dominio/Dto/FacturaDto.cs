using System;
using System.Linq;

namespace Facturacion.Dominio.Dto
{
    public class FacturaDto 
    {
        public Guid FacturaId { get; set; } = Guid.NewGuid();
        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public DetalleClienteDto DetalleCliente { get; set; }

        public DetalleProductoDto DetalleProducto { get; set; }

        public string Compra => DetalleProducto.DetalleProducto.MontoTotalCancelar.ToString("0.00");
        //public string Pagado => DetalleCliente.Cliente.CuentaCliente.Haber.ToString("0.00");

        //public string Saldo => DetalleCliente.Cliente.CuentaCliente.Debe.ToString("0.00");

        //public DateTime UltPago => DetalleCliente.Cliente.CuentaCliente.Movimientos.First().FechaMovimiento;

        public string NombrePlan => DetalleProducto.DetalleProducto.Planes.First().NombrePlan;
    }
}
