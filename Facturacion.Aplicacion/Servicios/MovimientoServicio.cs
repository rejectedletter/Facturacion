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

        public List<MovimientoDto> ListarMovimientos(Guid cuentaClienteId)
        {
            try
            {
                var result = _query.GetMovimientos(cuentaClienteId);

                return _mapper.Map<List<MovimientoDto>>(result);
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
