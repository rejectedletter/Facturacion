using System;

namespace Facturacion.Dominio.Entities
{
    public class Plan
    {
        public Guid Id { get; set; }

        public int CantidadCuotas { get; set; }

        public decimal Porcentaje { get; set; }

        

        public Guid ProductoPlanId { get; set; }
    }
}
