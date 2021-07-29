using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infraestructura
{
    public class DbContext : IDisposable
    {
        private List<Producto> _productos = new List<Producto>();

        public List<Producto> Productos { get; set; }

        public DbContext()
        {
            
            _productos.Add
            (
            
                new Producto() { Descripcion = "Lapiz", Id = new Guid("9c664981-b500-4340-9300-714f26b53dc8"), PrecioUnitario = 12 }
            );

            Productos = _productos;
        }

        public void Agregar(Producto producto)
        {
            Productos.Add(producto);
        }
        public void Dispose()
        {

            GC.SuppressFinalize(this);
        }
    }
}
