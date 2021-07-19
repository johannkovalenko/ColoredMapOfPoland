using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System;

namespace Model
{
    public class BMP_Test : I_BMP 
    {
        private Bitmap bmp = new Bitmap(@"powiaty_wzór.png");
        private BitmapData bitmapData;
        private int bytesPerPixel;
        
        public BMP_Test()
        {     
            bitmapData =  bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);      
            bytesPerPixel = Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
            byte[] pixels = new byte[bitmapData.Stride * bmp.Height];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            
            
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;
        
            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                {
                    int oldBlue = pixels[currentLine + x];
                    int oldGreen = pixels[currentLine + x + 1];
                    int oldRed = pixels[currentLine + x + 2];
                    
                    // calculate new pixel value
                    pixels[currentLine + x] = (byte)oldBlue;
                    pixels[currentLine + x + 1] = (byte)oldGreen;
                    pixels[currentLine + x + 2] = (byte)oldRed;
                }
            }
        
            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            bmp.UnlockBits(bitmapData);
        }

        public Color GetPixel(int x, int y)
        {
            return Color.Red;
        }

        public void SetPixel(int x, int y, Color color)
        {

        }

        public void Save(string file)
        {
            bmp.Save(@"..\output\" + Path.GetFileNameWithoutExtension(file) + ".png", ImageFormat.Png);
            bmp.Dispose();
        }
    }
}