using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio.Entities
{
    public class ProductosPlanes
    {
        public Guid id { get; set; }
        public Guid ProductoId { get; set; }

        public Guid PlanId { get; set; }
    }
}
