using Facturacion.Dominio.Entities;
using Dapper;
using System;
using Facturacion.Dominio.Dto;
using System.Collections.Generic;
using System.Data.SqlClient;
using Facturacion.Dominio;

namespace Facturacion.Infraestructura.Dapper
{
    public class ClientesQuery
    {
        public static List<ClientesResult> GetClientes()
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
            ,cli.CuentaclienteId
            ,zona.NombreZona
            ,prod.Descripcion
            ,prod.MontoTotalCancelar
            ,pla.NombrePlan
            FROM [Facturacion_Gimnasio_Juan].[dbo].[Clientes] as cli
            left JOIN [Facturacion_Gimnasio_Juan].[dbo].[Zonas] as zona ON cli.ZonaId = zona.ZonaId
            left JOIN [Facturacion_Gimnasio_Juan].[dbo].[Productos] as prod ON cli.ProductoId = prod.ProductoId
            left join Facturacion_Gimnasio_Juan.dbo.ProductosPlanes as pp on pp.ProductoId = prod.ProductoId
            left JOIN Facturacion_Gimnasio_Juan.dbo.Planes as pla on pla.PlanId = pp.PlantId" ;

            using(var connection = new DbConn())
            {
                return connection.Connection.Query<ClientesResult>(query).AsList();

            }     
        }

        public static bool Addclientes(Cliente cliente)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Clientes]
           ([ClienteId]
            ,[NroCliente]
            ,[Apellido]
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
            ,[ProductoId])
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
           ,@CuentaClienteId
           ,@ZonaId
           ,@ProductoId)";

            using (var connection = new DbConn())
            {
                if (connection.Connection.Execute(query, new
                {
                    ClienteId = cliente.ClienteId,
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

        public static void ExecuteTransactCliente(Cliente cliente, Producto producto,
            ProductosPlanes productosPlanes, CuentaCliente cuentaCliente)
        {
            var query = @"begin transaction
            INSERT INTO[Facturacion_Gimnasio_Juan].[dbo].[Clientes]
          ([ClienteId]
            ,[NroCliente]
            ,[Apellido]
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
            ,[ProductoId])
            VALUES
           (@ClienteId
           , @NroCliente
           , @Apellido
           , @Nombre
           , @DNI
           , @FechaNacimiento
           , @DomicilioParticular
           , @DomicilioComercial
           , @NroCelular
           , @TelefonoFijo
           , @Rubro
           , @CuentaClienteId
           , @ZonaId
           , @ProductoId)


     INSERT INTO[Facturacion_Gimnasio_Juan].[dbo].[Productos]
          ([ProductoId]
           ,[Descripcion]
           ,[MontoTotalCancelar])
             VALUES
           (@Id
           ,@Descripcion
           ,@MontoTotalCancelar)


     INSERT INTO[Facturacion_Gimnasio_Juan].[dbo].[ProductosPlanes]
          ([ProductosPlanesId]
           ,[ProductoId]
           ,[PlantId]
           ,[FechaInicioPlanPago]
           ,[Cancelado])
     VALUES
           (@ProductosPlanesId
           ,@PPProductoId
           ,@PlantId
           ,@FechaInicioPlanPago
           ,@Cancelado)
           
    INSERT INTO[Facturacion_Gimnasio_Juan].[dbo].[CuentaCliente]
          ([CuentaClienteId]
           ,[Debe]
           ,[Haber]
           ,[ProductoId])
             VALUES
           (@CCuentaclienteId
           ,@Debe
           ,@Haber
           ,@CCProductoId
          )


            commit ";

            using (var conn = new DbConn())
            {
                conn.Connection.Execute(query, new
                {
                    ClienteId = cliente.ClienteId,
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
                    ProductoId = cliente.ProductoId,
                    Id = producto.ProductoId,
                    Descripcion = producto.Descripcion,
                    MontoTotalCancelar = producto.MontoTotalCancelar,
                    ProductosPlanesId = productosPlanes.ProductosPlanesId,
                    PPProductoId = productosPlanes.ProductoId,
                    PlantId = productosPlanes.PlanId,
                    FechaInicioPlanPago = productosPlanes.FechaInicioPlanPago,
                    Cancelado = productosPlanes.Cancelado,
                    CCuentaClienteId = cuentaCliente.CuentaClienteId,
                    Debe = cuentaCliente.Debe,
                    Haber = cuentaCliente.Haber,
                    CCProductoId = cuentaCliente.ProductoId                }

                    );
            }
        }
        

    }

    
    public class SQLTRansactions
    {
        public void BeginClienteTransaction(Dictionary<string, DynamicParameters> executable)
        {
            var connection = new DbConn();

            connection.Connection.BeginTransaction();

            foreach (KeyValuePair<string, DynamicParameters> ex in executable)
            {
                connection.Connection.Execute(ex.Key, ex.Value);
            }

            
        }
    }
}
