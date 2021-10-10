using AutoMapper;
using Facturacion.Dominio.Dto;

using Facturacion.Infraestructura;
using Facturacion.Infraestructura.Dapper;
using Facturacion.Infraestructura.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Aplicacion.Servicios
{
    public class ZonaServicio
    {
        //IMapper _mapper;
        //public ZonaServicio()
        //{
           
        //    var configuration = new MapperConfiguration(cfg =>
        //    cfg.CreateMap<Zona, ZonaDto>());

        //    _mapper = new Mapper(configuration);
        //}

        public bool AgregarZona(Zona zona)
        {
            try
            {
                using (var context = new Facturacion_Gimnasio_JuanEntities())
                {
                    context.Zonas.Add(zona);
                }
                return true;
            }
            catch(Exception e)
            {
                
                throw new Exception("No se pudo agregar la zona.");
            }
        }

        

        public bool EliminarZona(Guid id)
        {
            try
            {
                using (var context = new Facturacion_Gimnasio_JuanEntities())
                {
                    var zonaEliminar = context.Zonas.SingleOrDefault(x => x.ZonaId == id);
                    
                    zonaEliminar.Eliminado = true;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                throw new Exception("No se pudo agregar la zona.");
            }
        }

        public List<Zona> ListarZonas()
        {
            //return Mapper.Map<List<ZonaDto>>(ZonaQuery.GetZonas());

            using (var context = new Facturacion_Gimnasio_JuanEntities())
            {
                return context.Zonas.Where(x => x.Eliminado == false).ToList();
            }
             
        }


    }
}
