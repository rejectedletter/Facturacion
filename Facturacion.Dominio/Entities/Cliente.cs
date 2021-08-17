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

        public string ApYNom => Apellido + " " + Nombre;

        public string Direccion { get; set; }

        public Guid CuentaClienteId { get; set; }

        public Zona Zona { get; set; }

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
