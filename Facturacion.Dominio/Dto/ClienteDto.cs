using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public int NroCliente { get; set; }

        //codigo complejo
        public string CodigoCliente { get; set; }

        public string ApellidoYNombre { get; set; }

        public string Direccion { get; set; }

        public ZonaDto Zona { get; set; }

        public ICollection<ProductoDto> Producto { get; set; }
    }
}
