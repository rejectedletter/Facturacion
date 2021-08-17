using System;

namespace Facturacion.Dominio.Dto
{
    public class FacturaDto
    {
        public Guid Id { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public DetalleClienteDto DetalleCliente { get; set; }

        public DetalleProductoDto DetalleProducto { get; set; }
    }
}
