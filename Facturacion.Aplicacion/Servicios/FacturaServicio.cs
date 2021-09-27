using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Aplicacion.Servicios
{
    public class FacturaServicio
    {
        FacturacionQuery servicio = new FacturacionQuery();
        public void Agregar(ClienteDto cliente, ProductoDto producto)
        {
            var nuevaFactura = new FacturaDto();
            
            var detalleCliente = new DetalleCliente()
            {
                DetalleClienteId = new DetalleClienteDto().DetalleClienteId,
                ClienteId = cliente.ClienteId,
                FacturaId = nuevaFactura.FacturaId
            };
        }

        public List<InformeFacturacionDto> GetInformeFacturacion(string dni)
        {
            ObjetoMapper mapper = new ObjetoMapper();

            List<InformeFacturacionDto> lDto = new List<InformeFacturacionDto>();

            mapper.GetNuevoMapper<InformeFacturacion, InformeFacturacionDto>();
            foreach(var item in servicio.GetInformeFacturacion(dni))
            {
                var x = mapper.Mapear<InformeFacturacion, InformeFacturacionDto>(item);
                lDto.Add(x);
            }

            return lDto;
        }
    }
}
