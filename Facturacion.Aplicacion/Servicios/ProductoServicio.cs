using Facturacion.Dominio;
using Facturacion.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Aplicacion
{
    public static class ProductoServicio
    {
        public static void Agregar(Producto producto)
        {
            using (var context = new DbContext())
            {
                context.Agregar(producto);
            }
        }

        public static void Modificar(Producto producto)
        {

        }

        public static void Eliminar(Guid id)
        {

        }

        public static List<Producto> Listar(string cadena)
        {
            
            
            using (var context = new DbContext())
            {
                return context.Productos;
            }
            
           
        }

        public static Producto BuscarPorId(Guid id)
        {
            using (var context = new DbContext())
            {
                return context.Productos.FirstOrDefault(x => x.Id==id);
            }
        }
    }
}
