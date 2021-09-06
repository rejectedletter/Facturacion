using System;

namespace Facturacion.Dominio.Entities
{
    public class CuentaCliente
    {
        public Guid CuentaClienteId { get; set; }

        public decimal Debe { get; set; }

        public decimal Haber { get; set; }

        public Guid ProductoId { get; set; }

        public Guid MovimientoId { get; set; }
    }
}
