using System.Drawing;
using System.IO;

namespace Facturacion.Resources
{
    public static class ImageStatics
    {
        public static Image delete = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), 
            "Resources/Iconos/058-error.png"));

        public static Image close = Image.FromFile(@"C:\Users\user\source\repos\Facturacion\Facturacion\148705-essential-collection\148705-essential-collection\png\084-multiply.png");
    }
}
