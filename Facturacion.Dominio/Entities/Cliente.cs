using System;

namespace Facturacion.Dominio.Entities
{

    public class Cliente 
    {
        public Guid ClienteId { get; set; }

        
        public int NroCliente { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public string DomicilioParticular { get; set; }

        public string DomicilioComercial { get; set; }

        public string NroCelular { get; set; }

        public string TelefonoFijo { get; set; }

        public string Rubro { get; set; }

        public Guid CuentaClienteId { get; set; }

        public Guid ZonaId { get; set; }

        public Guid ProductoId { get; set; }

    }
}
