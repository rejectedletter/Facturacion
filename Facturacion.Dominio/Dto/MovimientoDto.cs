using System;

namespace Facturacion.Dominio.Dto
{
    public class MovimientoDto
    {
        public Guid MovimientoId { get; set; } = Guid.NewGuid();

        public decimal Importe { get; set; }

        public decimal Debe { get; set; }

        public decimal Haber { get; set; }

        public EOperacion Operacion { get; set; }

        public DateTime FechaMovimiento { get; set; }
    }

    public class MovimientoResult
    {
        public Guid MovimientoId { get; set; }

        public int Operacion { get; set; }

        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal SaldoFechaActual { get; set; }

        public DateTime FechaMovimiento { get; set; }
        public string NombrePlan { get; set; }
        public DateTime FechaEstimadaCancelacion { get; set; }
    }
}
