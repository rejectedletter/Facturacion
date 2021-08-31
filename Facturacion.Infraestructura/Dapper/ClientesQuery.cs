using Facturacion.Dominio.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Facturacion.Dominio;

namespace Facturacion.Infraestructura.Dapper
{
    public class ClientesQuery
    {
        public static List<Cliente> GetClientesByZone(string zoneId)
        {
            var query = $@"SELECT cli.Id
            ,cli.NroCliente
            ,cli.CodigoCliente
            ,cli.Apellido
            ,cli.Nombre
            ,cli.Direccion
            ,cli.CuentaClienteId
            ,cli.ZonaId
            ,cli.ProductoId
            ,cuenta.Id
            ,cuenta.Debe
            ,cuenta.Haber
            ,cuenta.MovimientoId
            ,cuenta.ProductoId
            ,zona.Id
            ,zona.NombreZona
            ,zona.ClienteId
            ,prod.Id
            ,prod.Descripcion
            ,prod.MontoTotalCancelar
            ,prod.ProductosPlanesId
            FROM {nameof(Cliente)}as cli
            INNER JOIN {nameof(CuentaCliente)} as cuenta ON cli.CuentaClienteId = cuenta.Id
            INNER JOIN {nameof(Zona)} as zona ON cli.ZonaId = zona.Id
            INNER JOIN {nameof(Producto)} as prod ON cli.ProductoId = prod.Id
            WHERE cli.zonaId = @zoneId" ;

            using (var connection = new DbConn())
            {


                return connection.Query<Cliente>(new CommandDefinition(query, new { zoneId })).ToList();
            }
        }

        public static List<Cliente> GetClientes()
        {
            var query = $@"SELECT cli.Id
            ,cli.NroCliente as NroCliente
            ,cli.CodigoCliente 
            ,cli.Apellido
            ,cli.Nombre
            ,cli.Direccion
            ,cuenta.Id
            ,cuenta.Debe
            ,cuenta.Haber
            ,cuenta.MovimientoId
            ,cuenta.ProductoId
            ,zona.Id
            ,zona.NombreZona
            ,zona.ClienteId
            ,prod.Id
            ,prod.Descripcion
            ,prod.MontoTotalCancelar
            ,prod.ProductosPlanesId
            FROM {nameof(Cliente)}as cli
            INNER JOIN {nameof(CuentaCliente)} as cuenta ON cli.CuentaClienteId = cuenta.Id
            INNER JOIN {nameof(Zona)} as zona ON cli.ZonaId = zona.Id
            INNER JOIN {nameof(Producto)} as prod ON cli.ProductoId = prod.Id";

            using (var connection = new DbConn())
            {
                return connection.Query<Cliente>(new CommandDefinition(query)).ToList();
            }
        }

        public static bool Addclientes(Cliente cliente)
        {
            var query = $@"INSERT INTO {nameof(Cliente)}
           ([Id]
           ,[NroCliente]
           ,[CodigoCliente]
           ,[Apellido]
           ,[Nombre]
           ,[Direccion]
           ,[CuentaClienteId]
           ,[ZonaId]
           ,[ProductoId])
             VALUES
           (<@Id, uniqueidentifier,>
           ,<@NroCliente, int,>
           ,<@CodigoCliente, varchar(50),>
           ,<@Apellido, varchar(50),>
           ,<@Nombre, varchar(50),>
           ,<@Direccion, varchar(50),>
           ,<@CuentaClienteId, uniqueidentifier,>
           ,<@ZonaId, uniqueidentifier,>
           ,<@ProductoId, uniqueidentifier,>)";
            
            using (var connection = new DbConn())
            {
                if (connection.Execute(query, new { Id = cliente.Id, 
                    NroCliente = cliente.NroCliente,
                    Codigocliente = cliente.CodigoCliente,
                    Apellido = cliente.CodigoCliente,
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
                if (connection.Execute(query, new {clienteId}) == 1)
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
