using AutoMapper;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura.Dapper;
using System;
using System.Collections.Generic;

namespace Facturacion.Aplicacion.Servicios
{
    public class ZonaServicio
    {
        IMapper _mapper;
        public ZonaServicio()
        {
           
            var configuration = new MapperConfiguration(cfg =>
            cfg.CreateMap<Zona, ZonaDto>());

            _mapper = new Mapper(configuration);
        }

        public void AgregarZona(ZonaDto zona)
        {
            try
            {
                ZonaQuery.AddCuentaCliente(new Zona() { Id = zona.Id, NombreZona = zona.NombreZona });
            }
            catch
            {

                throw new Exception("No se pudo agregar la zona.");
            }
        }

        public void ModificarZona(ZonaDto zona)
        {
            var zonaBuscar = ZonaQuery.GetZonaById(zona.Id);
            if (zonaBuscar == null)
            {
                throw new Exception("No se encontró zona");
            }

            ZonaQuery.UpdateCuentaCliente(zonaBuscar);
        }

        public void EliminarZona(ZonaDto zona)
        {
            var zonaBuscar = ZonaQuery.GetZonaById(zona.Id);
            if (zonaBuscar == null)
            {
                throw new Exception("No se encontró zona");
            }

            ZonaQuery.DeleteCuentaCliente(zonaBuscar.Id);
        }

        public List<ZonaDto> ListarZonas()
        {
            return _mapper.Map<List<ZonaDto>>(ZonaQuery.GetZonas());
             
        }


    }
}
