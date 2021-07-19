using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Model
{
    public class BMP_Prod : I_BMP 
    {
        private Bitmap bmp = new Bitmap(@"powiaty_wzór.png");

        public Color GetPixel(int x, int y)
        {
            return bmp.GetPixel(x, y);
        }

        public void SetPixel(int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
        }

        public void Save(string file)
        {
            bmp.Save(@"..\output\" + Path.GetFileNameWithoutExtension(file) + ".png", ImageFormat.Png);
            bmp.Dispose();
        }
    }
}