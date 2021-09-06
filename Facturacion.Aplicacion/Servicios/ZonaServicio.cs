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

        public bool AgregarZona(ZonaDto zona)
        {
            try
            {
                ZonaQuery.AddZona(new Zona() { ZonaId = zona.ZonaId, NombreZona = zona.NombreZona });
                return true;
            }
            catch(Exception e)
            {
                throw new Exception("No se pudo agregar la zona.");
            }
        }

        public bool ModificarZona(ZonaDto zona)
        {
            var zonaBuscar = ZonaQuery.GetZonaById(zona.ZonaId);
            zonaBuscar.NombreZona = zona.NombreZona;
            
            if (zonaBuscar == null)
            {
                throw new Exception("No se encontró zona");
            }

            try
            {
                ZonaQuery.UpdateZona(zonaBuscar);
                return true;
            }
            catch
            {

                throw;
            }
        }

        public bool EliminarZona(Guid id)
        {
            var zonaBuscar = ZonaQuery.GetZonaById(id);
            if (zonaBuscar == null)
            {
                throw new Exception("No se encontró zona");
            }

            try
            {
                ZonaQuery.DeleteZona(id);
                return true;
            }
            catch 
            {

                throw new Exception("No se pudo eliminar zona"); 
                
            }
        }

        public List<ZonaDto> ListarZonas()
        {
            return _mapper.Map<List<ZonaDto>>(ZonaQuery.GetZonas());
             
        }


    }
}
