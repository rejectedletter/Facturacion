using System;

namespace Facturacion.Dominio.Entities
{
    public class Movimiento
    {
        public Guid MovimientoId { get; set; }

        public decimal Importe { get; set; }

        public int Operacion { get; set; }

        public DateTime FechaMovimiento { get; set; }

        public Guid CuentaClienteId { get; set; }
    }
}
