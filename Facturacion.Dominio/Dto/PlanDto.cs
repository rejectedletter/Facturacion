using System;

namespace Facturacion.Dominio.Dto
{
    public class PlanDto
    {
        public Guid PlanId { get; set; } = Guid.NewGuid();

        public string NombrePlan { get; set; }
        public int CantidadCuotas { get; set; }

        public decimal Porcentaje { get; set; }

       
    }
}
