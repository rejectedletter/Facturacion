using Dapper;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Infraestructura.Dapper
{
    public class MovimientosQuery : DapperMaster
    {
        public  List<MovimientoResult> GetMovimientos(Guid cuentaClienteId)
        {
            var query = @"SELECT[MovimientoId]
				,mov.[Operacion]
                ,mov.[Importe]
                ,mov.[Debe]
                ,mov.[Haber]
			    ,cc.Debe as SaldoFechaActual
                ,mov.[FechaMovimiento]
                ,pla.NombrePlan
                ,pp.FechaEstimadaCancelacion
             
            FROM[Facturacion_Gimnasio_Juan].[dbo].[Movimientos] mov
            left join Facturacion_Gimnasio_Juan.dbo.CuentaCliente cc on mov.CuentaClienteId = cc.CuentaClienteId
            left join Facturacion_Gimnasio_Juan.dbo.ProductosPlanes pp on pp.ProductoId = cc.ProductoId
            left join Facturacion_Gimnasio_Juan.dbo.Planes pla on pp.PlantId = pla.PlanId
            where mov.CuentaClienteId = @CuentaClienteId";

            parametrosDapper = new DynamicParameters();
            parametrosDapper.Add("@CuentaClienteId", cuentaClienteId);

            return DapperExecuteReader<MovimientoResult>(nameof(MovimientoResult), query).ToList();
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
