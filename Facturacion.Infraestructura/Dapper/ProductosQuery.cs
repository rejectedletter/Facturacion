using Dapper;
using Facturacion.Dominio;
using System;
using System.Linq;

namespace Facturacion.Infraestructura.Dapper
{
    public class ProductosQuery
    {
        public static Producto GetProductoById(Guid id)
        {
            var query = $@"SELECT [ProductoId]
                        ,[Descripcion]
                        ,[MontoTotalCancelar]
                        FROM [Facturacion_Gimnasio_Juan].[dbo].[Productos]
                        where ProductoId = @id";

            using (var connection = new DbConn())
            {
                return connection.Connection.Query<Producto>(query, new { id }).ToList().First();
            }
        }

        public static bool AddProducto(Producto producto)
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
                if (connection.Connection.Execute(query, new
                {
                   Id = producto.ProductoId,
                   Descripcion = producto.Descripcion,
                   MontoTotalCancelar = producto.MontoTotalCancelar
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
