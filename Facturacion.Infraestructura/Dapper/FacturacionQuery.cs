using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace Facturacion.Infraestructura.Dapper
{
    public class FacturacionQuery:DapperMaster
    {
        //string sGetInforme = @"select 
        //                    Clientes.Apellido,
        //                    Clientes.Nombre,
        //                    clientes.DNI,
        //                    CuentaCliente.Debe
        //                    from 
        //                    Clientes
        //                    left join CuentaCliente on CuentaCliente.CuentaClienteId = Clientes.CuentaClienteId
        //                    where 
        //                    clientes.DNI = @dni";


        //public List<InformeFacturacion> GetInformeFacturacion(string dni)
        //{
        //    parametrosDapper = new DynamicParameters();
        //    parametrosDapper.Add("@dni", dni);

        //    var retorno = DapperExecuteReader<InformeFacturacion>("", sGetInforme).ToList();
        //    return retorno;
        //}
    }
}
