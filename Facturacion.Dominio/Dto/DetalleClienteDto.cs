using System;

namespace Facturacion.Dominio.Dto
{
    public class DetalleClienteDto
    {
        public Guid DetalleClienteId { get; set; } = Guid.NewGuid();

        public ClienteDto Cliente { get; set; }

        
    }
}
