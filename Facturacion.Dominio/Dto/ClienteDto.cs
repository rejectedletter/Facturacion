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

        public string DomicilioParticular { get; set; }

        public string DomicilioComercial { get; set; }

        public string NroCelular { get; set; }

        public string TelefonoFijo { get; set; }

        public string Rubro { get; set; }

        public CuentaClienteDto CuentaCliente { get; set; }

        public ZonaDto Zona { get; set; }

        public ICollection<ProductoDto> Productos { get; set; }

        public ICollection<ProductosPlanesDto> ProductosPlanes { get; set; }
    }
    public class ClientesResult
    {
        public Guid ClienteId { get; set; }

        public int Nrocliente { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string DomicilioParticular { get; set; }
        public string DomicilioComercial { get; set; }
        public string NroCelular { get; set; }
        public string TelefonoFijo { get; set; }
        public string Rubro { get; set; }
        public int MyProperty { get; set; }
        public Guid CuentaClienteId { get; set; }

        public string NombreZona { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoTotalCancelar { get; set; }
        public string NombrePlan { get; set; }
    }
    
}
