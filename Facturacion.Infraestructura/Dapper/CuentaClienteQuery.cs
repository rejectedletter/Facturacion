using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using Facturacion.Dominio.Entities;

namespace Facturacion.Infraestructura.Dapper
{
    public class CuentaClienteQuery
    {
        public static List<CuentaCliente> GetCuentasClientes(Guid cuentaClienteId)
        {
            var query = $@"SELECT [Id]
            ,[Debe]
            ,[Haber]
            ,[ProductoId]
            ,[MovimientoId]
            FROM[Facturacion_Gimnasio_Juan].[dbo].[CuentaCliente]
            WHERE Id = @cuentaClienteId";

            using (var connection = new DbConn())
            {
               return connection.Connection.Query<CuentaCliente>(query, new { cuentaClienteId }).ToList();
            }
        }

        public static bool AddCuentaCliente(CuentaCliente cuentaCliente)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[CuentaCliente]
           ([Id]
           ,[Debe]
           ,[Haber]
           ,[ProductoId]
           ,[MovimientoId])
             VALUES
           (<@Id, uniqueidentifier,>
           ,<@Debe, decimal(18,2),>
           ,<@Haber, decimal(18,2),>
           ,<@ProductoId, uniqueidentifier,>
           ,<@MovimientoId, uniqueidentifier,>)";

            using (var connection = new DbConn())
            {
                if (connection.Connection.Execute(query, new {
                    Id = cuentaCliente.CuentaClienteId,
                    Debe = cuentaCliente.Debe,
                    Haber = cuentaCliente.Haber,
                    ProductoId = cuentaCliente.ProductoId,
                    MovimientoId = cuentaCliente.MovimientoId
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
