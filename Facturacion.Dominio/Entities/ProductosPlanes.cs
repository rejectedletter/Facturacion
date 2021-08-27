using System;

namespace Facturacion.Dominio.Entities
{
    public class ProductosPlanes
    {
        public Guid Id { get; set; }
        public Guid ProductoId { get; set; }

        public Guid PlanId { get; set; }

        public bool Cancelado { get; set; }
    }
}
