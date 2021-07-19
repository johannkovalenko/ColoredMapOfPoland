using System.Drawing;

namespace Model
{
    public interface I_BMP
    {
        Color GetPixel(int x, int y);
        void SetPixel(int x, int y, Color color);
        void Save(string file);
    }
}