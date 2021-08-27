using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class ClienteDto : BaseDto
    {
        public int NroCliente { get; set; }

        //codigo complejo
        public string CodigoCliente { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string ApellidoYNombre { get; set; }

        public string Direccion { get; set; }

        public CuentaClienteDto CuentaCliente { get; set; }

        public ZonaDto Zona { get; set; }

        public ICollection<ProductoDto> Productos { get; set; }
    }
}
