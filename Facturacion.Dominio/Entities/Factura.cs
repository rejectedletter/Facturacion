using System;

namespace Facturacion.Dominio.Entities
{
    public class Factura
    {
        public Guid FacturaId { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public Guid DetallesProductoId { get; set; }

        public Guid DetallesClienteId { get; set; }

    }
}
