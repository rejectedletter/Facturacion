using System;
using System.Data;
using System.Data.SqlClient;

namespace Facturacion.Infraestructura
{
    public class DbConn : IDisposable
    {
        private string connectionString = @"Data Source = DESKTOP-CCIQKNA\SQLEXPRESS; Initial Catalog = Facturacion_Gimnasio_Juan; Integrated Security = True; User Id=sa; Password=sqlserver;";
        public readonly SqlConnection Connection;
        public SqlTransaction Transact;
        public DbConn()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            
            connection.Open();
            Connection = connection;
        }

        public IDbConnection GetConexionSql()
        {
            IDbConnection dbConnection = new SqlConnection(connectionString);
            return dbConnection;
        }

        public  void StartTransaction()
        {
           Transact = Connection.BeginTransaction();
        }

        public void Dispose()
        {

            //Connection.Close();
            GC.SuppressFinalize(this);
        }
    }

}
