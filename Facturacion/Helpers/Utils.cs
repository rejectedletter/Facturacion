using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Helpers
{
    public static class Utils
    {
        public static void AgregarColumnas(DataGridView dgv, object[] propiedades)
        {
            

            foreach (var prop in propiedades)
            {

                dgv.Columns[(((PropertyInfo)prop).Name)].HeaderText = FormatearNombre((((PropertyInfo)prop).Name));
            }
        }

        public static string FormatearNombre(string nombreCol)
        {
            foreach (var letter in nombreCol)
            {
                if (char.IsUpper(letter) && nombreCol.IndexOf(letter) != 0)
                {
                    nombreCol = nombreCol.Insert(nombreCol.IndexOf(letter), " ");
                }
            }

            return nombreCol;
        }
    }
}
