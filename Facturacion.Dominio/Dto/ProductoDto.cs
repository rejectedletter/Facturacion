using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class ProductoDto 
    {
        public Guid ProductoId { get; set; } = Guid.NewGuid();

        public string Descripcion { get; set; }
        //plan descripcion
        public ICollection<PlanDto> Planes { get; set; }

        //compra
        public decimal MontoTotalCancelar { get; set; }

    }
}
