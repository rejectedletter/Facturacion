using System;

namespace Facturacion.Dominio.Dto
{
    public class DetalleClienteDto
    {
        public Guid Id { get; set; }

        public ClienteDto Cliente { get; set; }

        
    }
}
