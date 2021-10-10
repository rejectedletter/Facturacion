using Facturacion.Dominio.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Presentacion.ABMS
{
    public partial class ABMMovimientocs : ABMBase
    {
        private readonly ClienteDto Cliente;
        public ABMMovimientocs(ClienteDto cliente)
        {
            Cliente = cliente;

            InitializeComponent();
        }

        protected override void RealizarOperacion()
        {
            var detalleCliente = new DetalleClienteDto()
            {
                Cliente = Cliente
            };

            var detalleProducto = new DetalleProductoDto()
            {
               // DetalleProducto = Cliente.Productos.First()
            };

            var factura = new FacturaDto()
            {
                Fecha = DateTime.Now,
                Monto = Convert.ToDecimal(textBox1.Text),
                DetalleCliente = detalleCliente,
                DetalleProducto = detalleProducto
            };

            //llamar servicio y verificar que esté ok
        }
    }
}
