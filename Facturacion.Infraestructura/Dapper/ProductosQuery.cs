using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Facturacion.Infraestructura.Dapper
{
    //public class ProductosQuery
    //{
    //    public static Producto GetProductoById(Guid id)
    //    {
    //        var query = $@"SELECT [ProductoId]
    //                    ,[Descripcion]
    //                    ,[MontoTotalCancelar]
    //                    FROM [Facturacion_Gimnasio_Juan].[dbo].[Productos]
    //                    where ProductoId = @id";

    //        using (var connection = new DbConn())
    //        {
    //            return connection.Connection.Query<Producto>(query, new { id }).ToList().First();
    //        }
    //    }

    //    public static bool AddProducto(Producto producto, SqlConnection connection = null)
    //    {
    //        var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Productos]
    //       ([Id]
    //       ,[Descripcion]
    //       ,[MontoTotalCancelar])
    //         VALUES
    //       (@Id
    //       ,@Descripcion
    //       ,@MontoTotalCancelar)";

    //        if (connection==null)
    //        {
    //            connection = new DbConn().Connection;
    //            if (connection.Execute(query, new
    //            {
    //                Id = producto.ProductoId,
    //                //Descripcion = producto.Descripcion,
    //                MontoTotalCancelar = producto.MontoTotalCancelar
    //            }) == 1)
    //            {
    //                return true;
    //            }
    //            else
    //            {
    //                return false;
    //            }
    //        }

    //        if (connection.Execute(query, new
    //        {
    //            Id = producto.ProductoId,
    //           // Descripcion = producto.Descripcion,
    //            MontoTotalCancelar = producto.MontoTotalCancelar
    //        }) == 1)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }


    //    }
    
}
