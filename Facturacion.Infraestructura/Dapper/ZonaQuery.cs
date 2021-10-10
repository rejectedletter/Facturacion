using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

//namespace Facturacion.Infraestructura.Dapper
//{
//    public class ZonaQuery
//    {
//        public static List<Zona> GetZonas()
//        {
//            var query = $@"SELECT [ZonaId]
//             ,[NombreZona]
//             FROM [Facturacion_Gimnasio_Juan].[dbo].[Zonas]";

//            using (var connection = new DbConn())
//            {
//                return connection.Connection.Query<Zona>(query).ToList();
//            }
//        }

//        public static Zona GetZonaById(Guid id)
//        {
//            var query = $@"SELECT [ZonaId]
//             ,[NombreZona]
//             FROM [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
//            WHERE ZonaId=@id";

//            using (var connection = new DbConn())
//            {
//                return connection.Connection.Query<Zona>(query, new { id }).ToList().First();
//            }
//        }

//        public static bool AddZona(Zona zona)
//        {
//            var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
//           ([ZonaId]
//           ,[NombreZona])
//            VALUES
//           ('{zona.ZonaId}', '{zona.NombreZona}')";

//            using (var connection = new DbConn())
//            {
//                if (connection.Connection.Execute(query) == 1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//        }

//        public static bool UpdateZona(Zona zona)
//        {
//            var query = $@"UPDATE [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
//            SET [NombreZona] = @NombreZona
//            WHERE ZonaId = @Id";

//            using (var connection = new DbConn())
//            {
//                if (connection.Connection.Execute(query, new
//                {
//                    Id = zona.ZonaId,
//                    NombreZona = zona.NombreZona,

//                }) == 1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//        }

//        public static bool DeleteZona(Guid id)
//        {
//            var query = $@"DELETE FROM [Facturacion_Gimnasio_Juan].[dbo].[Zonas]
//            WHERE ZonaId = @Id";

//            using (var connection = new DbConn())
//            {
//                if (connection.Connection.Execute(query, new
//                {
//                    Id = id

//                }) == 1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//        }
//    }
//}
