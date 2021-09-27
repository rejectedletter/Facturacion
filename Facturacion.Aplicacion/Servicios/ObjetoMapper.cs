using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Aplicacion.Servicios
{
    public class ObjetoMapper
    {
        MapperConfiguration config;
        IMapper mapper;

        public IMapper GetNuevoMapper<TEntrada, TSalida>()
        {
            config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TEntrada, TSalida>();
            });

            mapper = config.CreateMapper();

            return mapper;
        }

        public TSalida Mapear<TEntrada, TSalida>(TEntrada objeto)
        {
            return mapper.Map<TEntrada, TSalida>(objeto);
        }
    }
}
