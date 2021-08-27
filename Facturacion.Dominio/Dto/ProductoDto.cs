using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class ProductoDto : BaseDto
    {
        public string Descripcion { get; set; }

        public ICollection<PlanDto> Plan { get; set; }

        public decimal MontoTotalCancelar { get; set; }

    }
}
