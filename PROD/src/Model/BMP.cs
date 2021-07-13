using System.Drawing;

namespace Model
{
    public class BMP
    {
        private Bitmap bmp = new Bitmap(@"..\input\powiaty_wzór.png");

        public Color GetColorOfPoint(int x, int y)
        {
            return bmp.GetPixel(x, y);
        }

        public Bitmap Get()
        {
            return bmp;
        }
    }
}