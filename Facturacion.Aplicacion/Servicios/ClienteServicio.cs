using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Aplicacion.Servicios
{
    public class ClienteServicio
    {
        public static void Agregar(Cliente cliente)
        {
           

            using (var context = new DbContext())
            {
                context.AgregarClientes(cliente);
                
            }
        }

        public static void Modificar(Cliente cliente)
        {

        }

        public static void Eliminar(Guid id)
        {

        }

        public static List<Cliente> Listar(string cadena)
        {
            

            using (var context = new DbContext())
            {

                return context._clientes;
            }
            
        }
    }
}
