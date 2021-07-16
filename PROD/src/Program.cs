using System.Drawing;
using System.Drawing.Imaging;

static class Program
{
    private static Bitmap bmp = new Bitmap(@"powiaty_wzór.png");
    private static Model.Powiaty powiaty = new Model.Powiaty();
    private static Model.InputData inputData = new Model.InputData();
    private static Model.Analysis analysis    = new Model.Analysis(bmp);

    static void Main()
    {       
        Fill_Test();
        //Fill_Prod();
        bmp.Save(@"..\output\powiaty_filled.png", ImageFormat.Png);

    }

    private static void Fill_Test()
    {
        foreach (string powiat in powiaty.coordinates.Keys)
            foreach (Point point in powiaty.coordinates[powiat])
                analysis.Run(point.X, point.Y, Color.Red);
    }

    private static void Fill_Prod()
    {
        foreach (string powiat in inputData.data.Keys)
            if (powiaty.coordinates.ContainsKey(powiat))
                foreach (Point point in powiaty.coordinates[powiat])
                    analysis.Run(point.X, point.Y, inputData.data[powiat]);
    }
}


