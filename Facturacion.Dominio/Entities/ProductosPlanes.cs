using System;

namespace Facturacion.Dominio.Entities
{
    public class ProductosPlanes
    {
        public Guid id { get; set; }
        public Guid ProductoId { get; set; }

        public Guid PlanId { get; set; }
    }
}
