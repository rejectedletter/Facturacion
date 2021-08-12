using Facturacion.Dominio;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infraestructura
{
    public class DbContext : IDisposable
    {
        public List<Producto> _productos = new List<Producto>();
        public List<Cliente> _clientes = new List<Cliente>();
        public List<ClientesProductos> _clientesProductos = new List<ClientesProductos>();
        public List<Plan> _planes = new List<Plan>();
        public List<ProductosPlanes> _productosPlanes = new List<ProductosPlanes>();

        


        public DbContext()
        {
            
            _productos.Add
            (
            
                new Producto() {Id = new Guid("9c664981-b500-4340-9300-714f26b53dc8"), MontoTotalCancelar = 12 }
            );

            _clientes.Add( new Cliente() { Id=Guid.NewGuid(),Apellido="Vega", Nombre="Daniela", CodigoCliente="7797", Direccion="Los Sauces"});
        }

        public void AgregarProducto(Producto producto)
        {
            _productos.Add(producto);
        }

        public void AgregarPlan(Plan plan)
        {
            _planes.Add(plan);
        }

        public void AgregarRelacionclientesProductos(ClientesProductos clientesProductos)
        {
            _clientesProductos.Add(clientesProductos);
        }

        public void AgregarRelacionclientesProductos(ProductosPlanes productosPlanes)
        {
            _productosPlanes.Add(productosPlanes);
        }

        public void AgregarRelacionProductosPlanes(ProductosPlanes productosPlanes)
        {
            _productosPlanes.Add(productosPlanes);
        }

        public void AgregarClientes(Cliente cliente)
        {
            _clientes.Add(cliente);
        }
        public void Dispose()
        {

            GC.SuppressFinalize(this);
        }
    }
}
