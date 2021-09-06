using System;

namespace Facturacion.Dominio.Dto
{
    public class ZonaDto
    {
        public Guid ZonaId { get; set; } = Guid.NewGuid();

        public string NombreZona { get; set; }
    }
}
