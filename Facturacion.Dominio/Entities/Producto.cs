using System;

namespace Facturacion.Dominio
{
    public class Producto
    {
        
        public Guid Id { get; set; }

        public string Descripcion { get; set; }

        public decimal MontoTotalCancelar { get; set; }

        public Guid ProductosPlanesId { get; set; }
    }
}
