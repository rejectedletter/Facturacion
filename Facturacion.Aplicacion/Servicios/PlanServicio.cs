using Facturacion.Infraestructura.Diagram;
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
        public bool Agregar(Plan plan)
       {
            try
            {
                using (var db = new Facturacion_Gimnasio_JuanEntities())
                {
                     db.Plans.Add(plan);
                }
                return true;
            }
            catch(Exception ex)
            {

                throw new Exception("Error al agregar nuevo plan.");
            }
       }

        public List<Plan> ListarPlanes()
        {
            try
            {
                using (var db = new Facturacion_Gimnasio_JuanEntities())
                {
                   return db.Plans.Where(x=> x.Eliminado==false).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarPlan(Guid id)
        {
            try
            {
                using (var db = new Facturacion_Gimnasio_JuanEntities())
                {
                    var planEliminar = db.Plans.SingleOrDefault(x => x.PlanId == id);
                    
                    planEliminar.Eliminado = true;
                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception e)
            {

                throw new Exception("No se pudo eliminar el plan");
            }
        }
    }
}
