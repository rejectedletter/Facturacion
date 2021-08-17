using System;

namespace Facturacion.Dominio.Entities
{
    public class Factura
    {
        public Guid Id { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        
    }
}
