using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая
{
    class HelpFunction
    {
        //Метод для переобразования масива байтов в картинку
        public static Bitmap byteArrayToBitmap(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Bitmap returnImage = (Bitmap)Bitmap.FromStream(ms);
            return returnImage;
        }
    }
}
