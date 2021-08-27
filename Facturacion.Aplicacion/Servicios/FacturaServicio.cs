using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Aplicacion.Servicios
{
    public class FacturaServicio
    {
        public void Agregar(ClienteDto cliente, ProductoDto producto)
        {
            var nuevaFactura = new FacturaDto();
            
            var detalleCliente = new DetalleCliente()
            {
                Id = new DetalleClienteDto().Id,
                ClienteId = cliente.Id,
                FacturaId = nuevaFactura.Id
            };

           

        }
    }
}
