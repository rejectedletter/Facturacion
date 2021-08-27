using System;

namespace Facturacion.Dominio.Entities
{
    public class DetalleProducto
    {
        public Guid Id { get; set; }

        public Guid CuentaClienteId { get; set; }

        public Guid ProductoPlanId { get; set; }
    }
}
