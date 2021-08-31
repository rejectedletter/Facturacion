using Dapper;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infraestructura.Dapper
{
    public class ZonaQuery
    {
        public static List<Zona> GetZonas()
        {
            var query = $@"SELECT [Id]
             ,[NombreZona]
             FROM [Facturacion_Gimnasio_Juan].[dbo].[Zonas]";

            using (var connection = new DbConn())
            {
                return connection.Query<Zona>(query).ToList();
            }
        }

        public static Zona GetZonaById(Guid id)
        {
            var query = $@"SELECT [Id]
             ,[NombreZona]
             FROM [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
            WHERE Id=@id";

            using (var connection = new DbConn())
            {
                return connection.Query<Zona>(query, new { id }).ToList().First();
            }
        }

        public static bool AddCuentaCliente(Zona zona)
        {
            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
           ([Id]
           ,[NombreZona]
           ,[ClienteId])
             VALUES
           (<@Id, uniqueidentifier,>
           ,<@NombreZona, varchar(50),>)";

            using (var connection = new DbConn())
            {
                if (connection.Execute(query, new
                {
                    Id = zona.Id,
                    NombreZona = zona.NombreZona,
                    
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

        public static bool UpdateCuentaCliente(Zona zona)
        {
            var query = $@"UPDATE [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
            SET [NombreZona] = <@NombreZona, varchar(50),>
            WHERE Id = @Id";

            using (var connection = new DbConn())
            {
                if (connection.Execute(query, new
                {
                    Id = zona.Id,
                    NombreZona = zona.NombreZona,

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

        public static bool DeleteCuentaCliente(Guid id)
        {
            var query = $@"DELETE FROM [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
            WHERE Id = @Id";

            using (var connection = new DbConn())
            {
                if (connection.Execute(query, new
                {
                    Id = id

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
