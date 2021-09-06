using System;

namespace Facturacion.Dominio.Dto
{
    public class PlanDto
    {
        public Guid PlanId { get; set; } = Guid.NewGuid();

        public string Nombre { get; set; }
        public int CantidadCuotas { get; set; }

        public decimal Porcentaje { get; set; }

        public bool Cancelado { get; set; }
       
    }
}
