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
                DetalleClienteId = new DetalleClienteDto().DetalleClienteId,
                ClienteId = cliente.ClienteId,
                FacturaId = nuevaFactura.FacturaId
            };

           

        }
    }
}
