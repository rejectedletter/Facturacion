﻿using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Data.SqlClient;

namespace Facturacion.Infraestructura.Dapper
{
    //public class CuentaClienteQuery
    //{

    //    // Mapper _mapper;
        
    //    public CuentaClienteQuery()
    //    {
    //        //var configuration = new MapperConfiguration(cfg =>
    //        //{
    //        //    cfg.CreateMap<CuentaCliente, CuentaClienteDto>();
    //        //    cfg.CreateMap<Movimiento, MovimientoDto>();
    //        //    cfg.CreateMap<Producto, ProductoDto>();


    //        //});
    //        var _mapperCuentacliente = Mapper.CreateMap<CuentaCliente, CuentaClienteDto>();
    //        var mapperMovimiento = Mapper.CreateMap<Movimiento, MovimientoDto>();
    //        var mapperProducto = Mapper.CreateMap<Producto, ProductoDto>();



    //    }
    //    public  CuentaClienteDto GetCuentasClienteById(Guid cuentaClienteId)
    //    {
    //        var query = $@"SELECT [Id]
    //        ,[Debe]
    //        ,[Haber]
    //        ,[ProductoId]
    //        ,[MovimientoId]
    //        FROM[Facturacion_Gimnasio_Juan].[dbo].[CuentaCliente]
    //        WHERE Id = @cuentaClienteId";

    //        var cuentaCliente = new CuentaCliente();
    //        var cuentaClienteDto = new CuentaClienteDto();
            
    //        using (var connection = new DbConn())
    //        {
    //           cuentaCliente = connection.Connection.Query<CuentaCliente>(query, new { cuentaClienteId }).ToList().First();

                
    //        }

    //        if (cuentaCliente != null)
    //        {
    //            cuentaClienteDto = Mapper.Map<CuentaClienteDto>(cuentaCliente);
    //            cuentaClienteDto.Movimientos = Mapper.Map<List<MovimientoDto>> (new MovimientosQuery().GetMovimientos(cuentaCliente.CuentaClienteId));

    //            cuentaClienteDto.Producto = Mapper.Map<ProductoDto>(ProductosQuery.GetProductoById(cuentaCliente.ProductoId));

    //        }

    //        return cuentaClienteDto;
    //    }

    //    public static bool AddCuentaCliente(CuentaCliente cuentaCliente, SqlConnection connection=null)
    //    {
    //        var query = $@"INSERT INTO [Facturacion_Gimnasio_Juan].[dbo].[CuentaCliente]
    //       ([Id]
    //       ,[Debe]
    //       ,[Haber]
    //       ,[ProductoId]
    //       ,[MovimientoId])
    //         VALUES
    //       (<@Id, uniqueidentifier,>
    //       ,<@Debe, decimal(18,2),>
    //       ,<@Haber, decimal(18,2),>
    //       ,<@ProductoId, uniqueidentifier,>
    //       ,<@MovimientoId, uniqueidentifier,>)";

    //        if (connection ==null)
    //        {
    //            connection = new DbConn().Connection;
    //            if (connection.Execute(query, new {
    //                Id = cuentaCliente.CuentaClienteId,
    //                Debe = cuentaCliente.Debe,
    //                Haber = cuentaCliente.Haber,
    //                ProductoId = cuentaCliente.ProductoId,
                    
    //            }) == 1)
    //            {
    //                return true;
    //            }
    //            else
    //            {
    //                return false;
    //            }
    //        }

    //        if (connection.Execute(query, new
    //        {
    //            Id = cuentaCliente.CuentaClienteId,
    //            Debe = cuentaCliente.Debe,
    //            Haber = cuentaCliente.Haber,
    //            ProductoId = cuentaCliente.ProductoId,

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
