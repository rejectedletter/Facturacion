using Facturacion.Dominio.Dto;
using Facturacion.Presentacion.ABMS;
using System;
using System.Windows.Forms;

namespace Facturacion.Helpers
{
    public static class TriggerAbm
    {
        public static Form  ABMTrigger(Type type, TipoOperacion tipoOperacion, Guid? id = null)
        {
            Form form;

            if (type == typeof(PlanDto))
            {
                form = new ABMPlan(tipoOperacion);
                return form;
            }
            if (type == typeof(ProductoDto))
            {
                form = new ABMProducto(tipoOperacion, (Guid)id);
                return form;
            }
            if (type == typeof(ClienteDto))
            {
                form = new ABMCliente(tipoOperacion);
                return form;
            }
            if (type == typeof(ZonaDto))
            {
                form = new ABMZona(tipoOperacion, id);
                return form;
            }

            return null;
        }
    }
}
