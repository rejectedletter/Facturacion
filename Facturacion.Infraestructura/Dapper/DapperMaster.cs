using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infraestructura.Dapper
{
    public class DapperMaster : DbConn
    {
        public string sMensaje = "";
        protected DynamicParameters parametrosDapper;

        protected int DapperExecuteNonQuery(string sTipo, string transacSQL)
        {
            using (IDbConnection connection = GetConexionSql())
            {
                int retorno = 0;
                try
                {
                    connection.Open();
                    retorno = connection.Execute(transacSQL, parametrosDapper, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    sMensaje = ex.Message.ToString();
                    //AutoClosingMessageBox.Show(sMensaje, "Atención", 2000);
                }

                return retorno;
            }
        }

        protected IEnumerable<T> DapperExecuteReader<T>(string sTipo, string transacSQL)
        {
            IEnumerable<T> items = null;
            using (IDbConnection connection = GetConexionSql())
            {
                try
                {
                    connection.Open();
                    items = connection.Query<T>(transacSQL, parametrosDapper, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    sMensaje = ex.Message.ToString();
                    // AutoClosingMessageBox.Show(sMensaje, "Atención", 2000);
                }

                return items;
            }
        }
    }
}
