using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Aplicacion.Servicios
{
    public class PlanServicio
    {
        public static void Agregar(Plan plan, Guid productoId)
        {
            var relacionPlanProducto = new ProductosPlanes()
            {
                id = Guid.NewGuid(),
                PlanId = plan.id,
                ProductoId = productoId
            };

            using (var context = new DbContext())
            {
                context.AgregarPlan(plan);
                context.AgregarRelacionProductosPlanes(relacionPlanProducto);
            }
        }

        public static void Modificar(Plan plan, Guid clienteId)
        {

        }

        public static void Eliminar(Guid id)
        {

        }

        //no se si se usa

        //public static List<Plan> Listar(string cadena, Guid clienteId)
        //{
        //    var productos = new List<Plan>();

        //    using (var context = new DbContext())
        //    {
        //        var clientesProductos = context._clientesProductos.Where(x => x.ClienteId == clienteId);


        //        foreach (var relacion in clientesProductos)
        //        {
        //            productos.Add(context._productos.First(x => x.Id == relacion.ProductoId));
        //        }


        //    }
        //    return productos;
        //}

        //usar dto
        public static List<ProductosPlanes> Listar(string cadena, Guid clienteId)
        {
            var productos = new List<Plan>();

            using (var context = new DbContext())
            {
                var clientesProductos = context._clientesProductos.Where(x => x.ClienteId == clienteId);


                foreach (var relacion in clientesProductos)
                {
                    //productos.Add(context._productos.First(x => x.Id == relacion.ProductoId));
                }


            }
            return new List<ProductosPlanes>();
        }
    }
}
