using Facturacion.Dominio.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Facturacion.Dominio;
using System.Data;

namespace Facturacion.Infraestructura.Dapper
{
    public class ClientesQuery
    {
        public static DataTable GetClientes()
        {
            var query = $@"SELECT cli.ClienteId
            ,cli.NroCliente
            ,cli.Apellido
            ,cli.Nombre
            ,cli.Direccion
            ,cli.CuentaClienteId
            ,zona.NombreZona
            ,prod.Descripcion
            ,prod.MontoTotalCancelar
            ,pla.Nombre as NombrePlan
            FROM [Facturacion_Gimnasio_Juan].[dbo].[Clientes] as cli
            INNER JOIN [Facturacion_Gimnasio_Juan].[dbo].[Zonas] as zona ON cli.ZonaId = zona.ZonaId
            INNER JOIN [Facturacion_Gimnasio_Juan].[dbo].[Productos] as prod ON cli.ProductoId = prod.ProductoId
            inner join Facturacion_Gimnasio_Juan.dbo.ProductosPlanes as pp on pp.ProductoId = prod.ProductoId
            inner JOIN Facturacion_Gimnasio_Juan.dbo.Planes as pla on pla.PlanId = pp.PlantId" ;

            using (var connection = new DbConn())
            {
                return connection.Connection.Query<DataTable>(new CommandDefinition(query)).First();
            }
        }

        public static bool Addclientes(Cliente cliente)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Clientes]
           ([ClienteId]
           ,[NroCliente]
           ,[Apellido]
           ,[Nombre]
           ,[Direccion]
           ,[CuentaClienteId]
           ,[ZonaId]
           ,[ProductoId])
            VALUES
           (@ClienteId,
           ,@NroCliente,
           ,@Apellido,
           ,@Nombre,
           ,@Direccion,
           ,@CuentaClienteId,
           ,@ZonaId,
           ,@ProductoId)";
            
            using (var connection = new DbConn())
            {
                if (connection.Connection.Execute(query, new { ClienteId = cliente.ClienteId, 
                    NroCliente = cliente.NroCliente,
                    Apellido = cliente.Apellido,
                    Nombre = cliente.Nombre,
                    Direccion = cliente.Direccion,
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

        //modificar, eliminar??

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
