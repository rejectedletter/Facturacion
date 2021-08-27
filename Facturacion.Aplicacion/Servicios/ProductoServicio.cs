using Facturacion.Dominio;
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
