using System;

namespace Facturacion.Dominio.Entities
{
    public class Plan
    {
        public Guid PlanId { get; set; }

        public string Nombre { get; set; }

        public int CantidadCuotas { get; set; }

        public decimal Porcentaje { get; set; }

       
    }
}
