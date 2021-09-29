using AutoMapper;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura.Dapper;
using System;
using System.Collections.Generic;

namespace Facturacion.Aplicacion.Servicios
{
    public class MovimientoServicio
    {
        private MovimientosQuery _query = new MovimientosQuery();
        private readonly IMapper _mapper;
        public MovimientoServicio()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Movimiento, MovimientoDto>();


            });
        }
        public void ArgregarMovimiento(MovimientoDto movimiento)
        {

        }

        public void ModificarMovimiento(MovimientoDto movimiento)
        {

        }

        public List<MovimientoResult> ListarMovimientos(Guid cuentaClienteId)
        {
            try
            {
                return _query.GetMovimientos(cuentaClienteId);

                
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
