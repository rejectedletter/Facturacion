using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio.Entities
{
    public class ClientesProductos
    {
        public Guid id { get; set; }

        public Guid ClienteId { get; set; }

        public Guid ProductoId { get; set; }
    }
}
