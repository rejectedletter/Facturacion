using Dapper;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Infraestructura.Dapper
{
    public class MovimientosQuery
    {
        public static List<Movimiento> GetMovimientos(Guid cuentaClienteId)
        {
            var query = $@"SELECT  [MovimientoId]
                        ,[Importe]
                        ,[Operacion]
                        ,[FechaMovimiento]
                        ,[CuentaclienteId]
                        FROM [Facturacion_Gimnasio_Juan].[dbo].[Movimientos]
                        Where CuentaclienteId = '@cuentaclienteId";

            using (var connection = new DbConn())
            {
                return connection.Connection.Query<Movimiento>(query,new {cuentaClienteId }).ToList();
            }
        }

        public static bool AddMovimiento(Movimiento movimiento)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Movimientos]
           ([MovimientoId]
           ,[Importe]
           ,[Operacion]
           ,[FechaMovimiento]
           ,[CuentaClienteId])
     VALUES
           (@MovimientoId
           ,@Importe
           ,@Operacion
           ,@FechaMovimiento
           ,@CuentaClienteId)";

            using (var connection = new DbConn())
            {
                if (connection.Connection.Execute(query, new
                {
                    MovimientoId = movimiento.MovimientoId,
                    Importe = movimiento.Importe,
                    Operacion = movimiento.Operacion,
                    FechaMovimiento = movimiento.FechaMovimiento,
                    CuentaClienteId = movimiento.CuentaClienteId

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
