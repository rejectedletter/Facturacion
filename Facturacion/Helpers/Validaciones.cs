using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Facturacion.Helpers
{
    public static class Validaciones
    {
        public static void SoloLetras(KeyPressEventArgs e)
        {

            Regex rex = new Regex(@"^[a-zA-Z ]");

            if (rex.IsMatch(e.KeyChar.ToString()) || char.IsControl(e.KeyChar) || e.KeyChar == 32)

                e.Handled = false;

            else e.Handled = true;
        }

        public static void Numeros(KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 08)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void LetrasYNumeros(KeyPressEventArgs e)
        {
            Regex rex = new Regex(@"^[a-zA-Z0-9]");

            if (rex.IsMatch(e.KeyChar.ToString()) || char.IsControl(e.KeyChar) || e.KeyChar == 32)

                e.Handled = false;

            else e.Handled = true;
        }

    }
}
