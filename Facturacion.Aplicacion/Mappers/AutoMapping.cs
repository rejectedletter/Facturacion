using AutoMapper;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Aplicacion.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            ClienteDtoToCliente();
        }

        private void ClienteDtoToCliente()
        {
            CreateMap<ClienteDto, Cliente>()
                .ForMember(d => d.ZonaId, opt =>
                opt.MapFrom(s => s.Zona.ZonaId))
                .ForMember(d => d.CuentaClienteId, opt =>
                 opt.MapFrom(s => s.CuentaCliente.CuentaClienteId))
                .ForMember(d => d.ProductoId, opt =>
                 opt.MapFrom(s => s.Productos.First().ProductoId));


        }
    }
}
