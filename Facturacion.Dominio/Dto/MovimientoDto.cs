using System;

namespace Facturacion.Dominio.Dto
{
    public class MovimientoDto
    {
        public Guid Id { get; set; }

        public decimal Importe { get; set; }

        public EOperacion Operacion { get; set; }

        public DateTime FechaMovimiento { get; set; }
    }
}
