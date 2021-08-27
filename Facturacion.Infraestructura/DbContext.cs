using Facturacion.Dominio;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Facturacion.Infraestructura
{
    public class DbContext 
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => new SqlConnection("Data Source=localhost;Initial Catalog=Facturacion_Gimnasio_Juan;Integrated Security=True;MultiSubnetFailover=False;MultipleActiveResultSets=False;ApplicationIntent=ReadWrite;"); }

        public int ConnectionTimeout => throw new NotImplementedException();

        public string Database => throw new NotImplementedException();

        public ConnectionState State => throw new NotImplementedException();

        public DbContext()
        {
            
            
        }

        //public void AgregarProducto(Producto producto)
        //{
        //    _productos.Add(producto);
        //}

        //public void AgregarPlan(Plan plan)
        //{
        //    _planes.Add(plan);
        //}

        

        //public void AgregarRelacionclientesProductos(ProductosPlanes productosPlanes)
        //{
        //    _productosPlanes.Add(productosPlanes);
        //}

        //public void AgregarRelacionProductosPlanes(ProductosPlanes productosPlanes)
        //{
        //    _productosPlanes.Add(productosPlanes);
        //}

        //public void AgregarClientes(Cliente cliente)
        //{
        //    _clientes.Add(cliente);
        //}
        //public void Dispose()
        //{

        //    GC.SuppressFinalize(this);
        //}

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
