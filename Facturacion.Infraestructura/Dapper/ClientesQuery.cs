using Facturacion.Dominio.Entities;
using Dapper;
using System;
using Facturacion.Dominio.Dto;
using System.Collections.Generic;

namespace Facturacion.Infraestructura.Dapper
{
    public class ClientesQuery
    {
        public static List<dynamic> GetClientes()
        {
            var query = $@"SELECT cli.ClienteId
            ,cli.NroCliente
            ,cli.Apellido
            ,cli.Nombre
            ,cli.DNI
            ,cli.FechaNacimiento
            ,cli.DomicilioParticular
            ,cli.DomicilioComercial
            ,cli.NroCelular
            ,cli.TelefonoFijo
            ,cli.Rubro
            ,zona.NombreZona
            ,prod.Descripcion
            ,prod.MontoTotalCancelar
            ,pla.NombrePlan
            FROM [Facturacion_Gimnasio_Juan].[dbo].[Clientes] as cli
            INNER JOIN [Facturacion_Gimnasio_Juan].[dbo].[Zonas] as zona ON cli.ZonaId = zona.ZonaId
            INNER JOIN [Facturacion_Gimnasio_Juan].[dbo].[Productos] as prod ON cli.ProductoId = prod.ProductoId
            inner join Facturacion_Gimnasio_Juan.dbo.ProductosPlanes as pp on pp.ProductoId = prod.ProductoId
            inner JOIN Facturacion_Gimnasio_Juan.dbo.Planes as pla on pla.PlanId = pp.PlantId" ;

            using (var connection = new DbConn())
            {
                 return connection.Connection.Query<dynamic>(query).AsList();
                
            }
        }

        public static bool Addclientes(Cliente cliente)
        {
            var query = @"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Clientes]
           ([ClienteId],[NroCliente],[Apellido]
            ,[Nombre]
            ,[DNI]
            ,[FechaNacimiento]
            ,[DomicilioParticular]
            ,[DomicilioComercial]
            ,[NroCelular]
            ,[TelefonoFijo]
            ,[Rubro]
            ,[CuentaClienteId]
            ,[ZonaId]
            ,[ProductoId]])
            VALUES
           (@ClienteId
           ,@NroCliente
           ,@Apellido
           ,@Nombre
           ,@DNI
           ,@FechaNacimiento
            ,@DomicilioParticular
            ,@DomicilioComercial
            ,@NroCelular
            ,@TelefonoFijo
            ,@Rubro
           ,@CuentaClienteId,
           ,@ZonaId,
           ,@ProductoId)";
            
            using (var connection = new DbConn())
            {
                if (connection.Connection.Execute(query, new { ClienteId = cliente.ClienteId, 
                    NroCliente = cliente.NroCliente,
                    Apellido = cliente.Apellido,
                    Nombre = cliente.Nombre,
                    DNI = cliente.DNI,
                    FechaNacimiento = cliente.FechaNacimiento,
                    DomicilioParticular = cliente.DomicilioParticular,
                    DomicilioComercial = cliente.DomicilioComercial,
                    NroCelular = cliente.NroCelular,
                    TelefonoFijo = cliente.TelefonoFijo,
                    Rubro = cliente.Rubro,
                    CuentaClienteId = cliente.CuentaClienteId,
                    ZonaId = cliente.ZonaId,
                    ProductoId = cliente.ProductoId}) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                         
                }
            }
        }

        public static bool UpdateClientes(Cliente cliente)
        {
             var query = $@"UPDATE [Facturacion_Gimnasio_Juan].[dbo].[Clientes]
                        SET [NroCliente] = @NroCliente
                        ,[Apellido] = @Apellido
                        ,[Nombre] = @Nombre
                        ,[DNI] = @DNI
                        ,[FechaNacimiento]=@FechaNacimiento
                        ,DomicilioParticular = @DomicilioParticular
                        ,DomicilioComercial = @DomicilioComercial
                        ,NroCelular=@NroCelular
                        ,TelefonoFijo=@TelefonoFijo
                        ,Rubro = @Rubro
                        ,[CuentaClienteId] = @CuentaClienteId
                         ,[ZonaId] = @ZonaId
                        ,[ProductoId] = @ProductoId
                        WHERE ClienteId = @ClienteId";

                using (var connection = new DbConn())
                {
                    if (connection.Connection.Execute(query, new
                    {
                        NroCliente = cliente.NroCliente,
                        Apellido = cliente.Apellido,
                        Nombre = cliente.Nombre,
                        DNI = cliente.DNI,
                        FechaNacimiento = cliente.FechaNacimiento,
                        DomicilioParticular = cliente.DomicilioParticular,
                        DomicilioComercial = cliente.DomicilioComercial,
                        NroCelular = cliente.NroCelular,
                        TelefonoFijo = cliente.TelefonoFijo,
                        Rubro = cliente.Rubro,
                        CuentaClienteId = cliente.CuentaClienteId,
                        ZonaId = cliente.ZonaId,
                        ProductoId = cliente.ProductoId

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
        

        public static bool DeleteCliente(Guid clienteId)
        {
            var query = $@"DELETE FROM [Facturacion_Gimnasio_Juan].[dbo].[Clientes]
                    WHERE Id = @clienteId ";
            
            using (var connection = new DbConn())
            {
                if (connection.Connection.Execute(query, new {clienteId}) == 1)
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
