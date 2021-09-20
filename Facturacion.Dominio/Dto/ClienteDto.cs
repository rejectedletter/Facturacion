using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class ClienteDto 
    {

        public Guid ClienteId { get; set; } = Guid.NewGuid();
        public int NroCliente { get; set; }

       public string CodigoCliente => NroCliente.ToString() + "/6";

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Dni { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string ApellidoYNombre => $"{Apellido} {Nombre}";  

        public Domicilio  DomicilioParticular { get; set; }

        public Domicilio DomicilioComercial { get; set; }

        public string NroCelular { get; set; }

        public string TelefonoFijo { get; set; }

        public string Rubro { get; set; }

        public CuentaClienteDto CuentaCliente { get; set; }

        public ZonaDto Zona { get; set; }

        public ICollection<ProductoDto> Productos { get; set; }

        public ICollection<ProductosPlanesDto> ProductosPlanes { get; set; }
    }

    public class Domicilio
    {
        public string Direccion { get; set; }

        public string Barrio { get; set; }

        public string Localidad { get; set; }

    }
}
