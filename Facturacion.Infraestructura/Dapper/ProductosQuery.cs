using Dapper;
using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infraestructura.Dapper
{
    public class ProductosQuery
    {
        public static List<Producto> GetCuentasClientes(Guid cuentaClienteId)
        {
            var query = $@"SELECT [Id]
             ,[Descripcion]
             ,[MontoTotalCancelar]
             ,[ProductosPlanesId]
              FROM [Facturacion_Gimnasio_Juan].[dbo].[Productos]
             WHERE Id = @cuentaClienteId";

            using (var connection = new DbConn())
            {
                return connection.Query<Producto>(query, new { cuentaClienteId }).ToList();
            }
        }

        public static bool AddCuentaCliente(Producto producto)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Productos]
           ([Id]
           ,[Descripcion]
           ,[MontoTotalCancelar]
           ,[ProductosPlanesId])
             VALUES
           (<Id, uniqueidentifier,>
           ,<Descripcion, varchar(50),>
           ,<MontoTotalCancelar, decimal(18,2),>
           ,<ProductosPlanesId, uniqueidentifier,>)";

            using (var connection = new DbConn())
            {
                if (connection.Execute(query, new
                {
                   Id = producto.Id,
                   Descripcion = producto.Descripcion,
                   MontoTotalCancelar = producto.MontoTotalCancelar,
                   ProductosPlanesId = producto.ProductosPlanesId
                }) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
