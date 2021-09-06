using Dapper;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Infraestructura.Dapper
{
    public static  class PlanQuery
    {
        public static List<Plan> GetPlanes()
        {
            var query = $@"SELECT PlanId, Nombre, CantidadCuotas, Porcentaje 
            FROM [Facturacion_Gimnasio_Juan].[dbo].[Planes]";

            using (var connection = new DbConn())
            {
                return connection.Connection.Query<Plan>(query).ToList();
            }
        }

        public static Plan GetPlanById(Guid id)
        {
            var query = $@"SELECT PlanId, Nombre, CantidadCuotas, Porcentaje 
            FROM [Facturacion_Gimnasio_Juan].[dbo].[Planes]
            WHERE PlanId = @id";

            using (var connection = new DbConn())
            {
                return connection.Connection.Query<Plan>(query, new { id }).ToList().First();
            }
        }

        public static bool AddPlan(Plan plan)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Planes]
           ([PlanId]
           ,[Nombre]
           ,[CantidadCuotas]
           ,[Porcentaje])
            VALUES
           (@planId, @nombre, @cantidadCuotas, @porcentaje)";

            using (var connection = new DbConn())
            {
                if (connection.Connection.Execute(query, new 
                {
                    planId = plan.PlanId,
                    nombre = plan.Nombre,
                    cantidadCuotas = plan.CantidadCuotas,
                    porcentaje = plan.Porcentaje

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
