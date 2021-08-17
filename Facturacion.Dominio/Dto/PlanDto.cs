using System;

namespace Facturacion.Dominio.Dto
{
    public class PlanDto
    {
        public Guid Id { get; set; }

        public int CantidadCuotas { get; set; }

        public decimal Porcentaje { get; set; }

        public bool Cancelado { get; set; }
    }
}
