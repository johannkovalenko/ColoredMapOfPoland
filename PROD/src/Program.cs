using System.Drawing;
using System.Drawing.Imaging;

static class Program
{
    static void Main()
    {
        var powiaty = new Model.Powiaty();
        var inputData = new Model.InputData();

        var bmp = new Bitmap(@"..\input\powiaty_wzór.png");
        var analysis    = new Model.Analysis(bmp);
        
        foreach (string powiat in inputData.data.Keys)
            if (powiaty.coordinates.ContainsKey(powiat))
                analysis.Run(powiaty.coordinates[powiat].X, powiaty.coordinates[powiat].Y, inputData.data[powiat]);

        bmp.Save(@"..\input\powiaty_filled.png", ImageFormat.Png);

    }
}
