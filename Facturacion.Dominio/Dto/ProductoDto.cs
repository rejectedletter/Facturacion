using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class ProductoDto 
    {
        public Guid ProductoId { get; set; } = Guid.NewGuid();
        public string Descripcion { get; set; }

        public ICollection<PlanDto> Plan { get; set; }

        public decimal MontoTotalCancelar { get; set; }

    }
}
