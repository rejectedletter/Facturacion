using System;

namespace Facturacion.Dominio.Entities
{
    public class DetalleProducto
    {
        public Guid Id { get; set; }

        public Guid CuentaCliente { get; set; }

        public Guid ProductoPlanId { get; set; }
    }
}
