using System;

namespace Facturacion.Dominio.Entities
{

    public class Cliente 
    {
        public Guid Id { get; set; }

        
        public int NroCliente { get; set; }

        //codigo complejo
        public string CodigoCliente { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        
        public string Direccion { get; set; }

        public Guid CuentaClienteId { get; set; }

        public Guid ZonaId { get; set; }

        public Guid ProductoId { get; set; }

        public object[] ObtenerPropiedades()
        {
           return this.GetType().GetProperties();
        }

        public Cliente()
        {
            ObtenerPropiedades();
        }
    }
}
