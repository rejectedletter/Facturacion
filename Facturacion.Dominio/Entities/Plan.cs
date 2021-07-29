using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio.Entities
{
    public class Plan
    {
        public Guid id { get; set; }

        public int cantidadCuotas { get; set; }

        public decimal alicuota { get; set; }
    }
}
