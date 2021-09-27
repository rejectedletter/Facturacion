using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infraestructura.Dapper
{
    public  class DapperExecutor
    {
        public bool Insert(string sql, object args)
        {
            using (var connection = new DbConn())
            {
              return  connection.Connection.Execute(sql, args) ==1 ;
            }
        }

        public void Transaction(Dictionary<string, object> executable)
        {
            using (var connection = new DbConn())
            {
                var transact = connection.Connection.BeginTransaction();

                foreach (KeyValuePair<string, object> ex in executable)
                {
                    connection.Connection.Execute(ex.Key, ex.Value);
                }

                transact.Commit();
            }
        }
    }
}
