using System;

namespace Facturacion.Dominio.Entities
{
    public class DetalleCliente
    {
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public Guid FacturaId { get; set; }
    }
}
