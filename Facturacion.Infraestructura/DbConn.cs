using System;
using System.Data;
using System.Data.SqlClient;

namespace Facturacion.Infraestructura
{
    public class DbConn : IDisposable
    {
        private string connectionString = @"Data Source = DESKTOP-ALJK62P\SQLEXPRESS; Initial Catalog = Facturacion_Gimnasio_Juan; Integrated Security = True; User Id=sa; Password=Whatsername;";
        public readonly SqlConnection Connection;
        public DbConn()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            
            connection.Open();
            Connection = connection;

            
        }

        public void Dispose()
        {

            //Connection.Close();
            GC.SuppressFinalize(this);
        }
    }

}
