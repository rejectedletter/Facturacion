using Dapper;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Infraestructura.Dapper
{
    public class MovimientosQuery : DapperMaster
    {
        public  List<Movimiento> GetMovimientos(Guid cuentaClienteId)
        {
            var query = @"SELECT[MovimientoId]
                ,[Importe]
                ,[Operacion]
                ,[Debe]
                ,[Haber]
                ,[FechaMovimiento]
                ,[CuentaClienteId]
            FROM[Facturacion_Gimnasio_Juan].[dbo].[Movimientos]
            where CuentaClienteId = @CuentaClienteId";

            return DapperExecuteReader<Movimiento>(nameof(Movimiento), query).ToList();
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
