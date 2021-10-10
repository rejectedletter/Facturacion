using AutoMapper;
using Facturacion.Dominio.Dto;
using Facturacion.Infraestructura.Dapper;
using System.Collections.Generic;

namespace Facturacion.Aplicacion.Servicios
{
    public class FacturaServicio
    {
        FacturacionQuery servicio = new FacturacionQuery();
        public void Agregar(ClienteDto cliente, ProductoDto producto)
        {
            var nuevaFactura = new FacturaDto();
            
           
        }

        public List<InformeFacturacionDto> GetInformeFacturacion(string dni)
        {
            ObjetoMapper mapper = new ObjetoMapper();

            List<InformeFacturacionDto> lDto = new List<InformeFacturacionDto>();

           
            

            return lDto;
        }
    }
}
