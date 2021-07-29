using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio.Entities
{
    public class Cliente
    {
        public int nrocliente { get; set; }

        //codigo complejo
        public string codigoCliente { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string ApyNom => Apellido + " " + Nombre;

        public string Direccion { get; set; }
    }
}
