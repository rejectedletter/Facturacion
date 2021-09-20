using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio.Dto
{
    public class DetalleProductoDto
    {
        public Guid DetalleProductoId { get; set; } = Guid.NewGuid();

        public ProductoDto DetalleProducto { get; set; }

        
    }
}
