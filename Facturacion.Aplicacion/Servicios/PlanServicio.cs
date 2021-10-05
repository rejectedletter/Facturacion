using AutoMapper;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura;
using Facturacion.Infraestructura.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Aplicacion.Servicios
{
    public class PlanServicio
    {
        //readonly IMapper _mapper;
        public PlanServicio()
        {

            //var configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Plan, PlanDto>()
            //    .ForMember(c => c.Porcentaje, o
            //    => o.MapFrom(s=>s.Porcentaje));

            //    cfg.CreateMap<PlanDto, Plan>();
            //});

            //_mapper = new Mapper(configuration);
        }
        public bool Agregar(PlanDto plan)
       {
            try
            {
                PlanQuery.AddPlan(Mapper.Map<Plan>(plan));
                return true;
            }
            catch(Exception ex)
            {

                throw new Exception("Error al agregar nuevo plan.");
            }
       }

        public List<PlanDto> ListarPlanes()
        {
            return Mapper.Map<List<PlanDto>>(PlanQuery.GetPlanes());
        }

        public bool EliminarPlan(Guid value)
        {
           return PlanQuery.DeletePlan( value);
        }
    }
}
