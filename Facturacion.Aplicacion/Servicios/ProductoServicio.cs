using Facturacion.Dominio;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Aplicacion
{
    public static class ProductoServicio
    {
        public static void Agregar(Producto producto, Guid clienteId)
        {
            var relacionProductocliente = new ClientesProductos()
            {
                id = Guid.NewGuid(),
                ClienteId = clienteId,
                ProductoId = producto.Id
            };
            
            using (var context = new DbContext())
            {
                context.AgregarProducto(producto);
                context.AgregarRelacionclientesProductos(relacionProductocliente);
            }
        }

        public static void Modificar(Producto producto, Guid clienteId)
        {

        }

        public static void Eliminar(Guid id)
        {

        }

        public static List<Producto> Listar(string cadena, Guid clienteId)
        {
            var productos = new List<Producto>();

            using (var context = new DbContext())
            {
                var clientesProductos = context._clientesProductos.Where(x => x.ClienteId == clienteId);
                

                foreach (var relacion in clientesProductos)
                {
                    productos.Add(context._productos.First(x => x.Id == relacion.ProductoId));
                }

               
            }
            return productos;
        }


    

    //public static Producto BuscarPorId(Guid id)
    //{
    //    using (var context = new DbContext())
    //    {
    //        return context.Productos.FirstOrDefault(x => x.Id == id);
    //    }
    //}


}
}
