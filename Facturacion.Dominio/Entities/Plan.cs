using System;

namespace Facturacion.Dominio.Entities
{
    public class Plan
    {
        public Guid PlanId { get; set; }

        public string NombrePlan { get; set; }

        public int CantidadCuotas { get; set; }

        public decimal Porcentaje { get; set; }

       
    }
}
