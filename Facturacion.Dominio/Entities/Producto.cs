using System;

namespace Facturacion.Dominio
{
    public class Producto
    {
        
        public Guid ProductoId { get; set; }

        public string Descripcion { get; set; }

        public decimal MontoTotalCancelar { get; set; }

        
    }
}
