using Dapper;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Facturacion.Infraestructura.Dapper
{
    public class ProductosPlanesQuery
    {
        public static List<dynamic> GetProductosEnFunciondePlanes(Guid clienteId)
        {
            var query = $@"SELECT cli.ProductoId
                , pro.MontoTotalCancelar
                , pro.Descripcion
	            , pla.NombrePlan
	            , pp.Cancelado
	            , pp.FechaInicioPlanPago
	   
 
                FROM [Facturacion_Gimnasio_Juan].[dbo].[Clientes] as cli
                 inner join Facturacion_Gimnasio_Juan.dbo.Productos as pro on pro.ProductoId = cli.ProductoId
                 inner join Facturacion_Gimnasio_Juan.dbo.ProductosPlanes as pp on pp.ProductoId = cli.ProductoId
                 inner join Facturacion_Gimnasio_Juan.dbo.Planes as pla on pla.PlanId = pp.PlantId
  
                where cli.ClienteId = @clienteId";

            using (var connection = new DbConn())
            {
                return connection.Connection.Query<dynamic>(query, new { clienteId }).ToList();

            }
        }

        public static bool AddProductosPlanes(ProductosPlanes productosPlanes, SqlConnection connection = null)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[ProductosPlanes]
           ([ProductosPlanesId]
           ,[ProductoId]
           ,[PlantId]
           ,[FechaInicioPlanPago]
           ,[Cancelado])
     VALUES
           (@ProductosPlanesId, uniqueidentifier,>
           ,@ProductoId, uniqueidentifier,>
           ,@PlantId, uniqueidentifier,>
           ,@FechaInicioPlanPago, datetime,>
           ,@Cancelado, bit,>)";

            if(connection == null)
            {
                connection = new DbConn().Connection;

                if (connection.Execute(query, new
                {
                    ProductosPlanesId = productosPlanes.ProductosPlanesId,
                    ProductoId = productosPlanes.ProductoId,
                    PlantId = productosPlanes.PlanId,
                    FechaInicioPlanPago = productosPlanes.FechaInicioPlanPago,
                    Cancelado = productosPlanes.Cancelado

                }) == 1)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }

            if (connection.Execute(query, new
            {
                ProductosPlanesId = productosPlanes.ProductosPlanesId,
                ProductoId = productosPlanes.ProductoId,
                PlantId = productosPlanes.PlanId,
                FechaInicioPlanPago = productosPlanes.FechaInicioPlanPago,
                Cancelado = productosPlanes.Cancelado

            }) == 1)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //public static bool UpdateClientes(Cliente cliente)
        //{
        //    var query = $@"UPDATE [Facturacion_Gimnasio_Juan].[dbo].[Clientes]
        //                SET [NroCliente] = @NroCliente
        //                ,[Apellido] = @Apellido
        //                ,[Nombre] = @Nombre
        //                ,[Direccion] = Direccion
        //                ,[CuentaClienteId] = @CuentaClienteId
        //                 ,[ZonaId] = @ZonaId
        //                ,[ProductoId] = @ProductoId
        //                WHERE ClienteId = @ClienteId";

        //    using (var connection = new DbConn())
        //    {
        //        if (connection.Connection.Execute(query, new
        //        {
        //            NroCliente = cliente.NroCliente,
        //            Apellido = cliente.Apellido,
        //            Nombre = cliente.Nombre,
        //            Direccion = cliente.Direccion,
        //            CuentaClienteId = cliente.CuentaClienteId,
        //            ZonaId = cliente.ZonaId,
        //            ProductoId = cliente.ProductoId,
        //            ClienteId = cliente.ClienteId

        //        }) == 1)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}


        

    }
}

