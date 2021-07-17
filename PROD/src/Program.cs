using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

static class Program
{
    static void Main()
    {   
        var powiaty = new Model.Powiaty();  
        var analysis    = new Model.Analysis();
        var strategies = new Model.Strategies();

        foreach (string file in Directory.GetFiles("..\\input"))
        {
              
            var bmp = new Bitmap(@"powiaty_wzór.png");
            analysis.UpdateBMP(bmp);
            
            Model.I_InputData inputData = strategies.Get(file);
            inputData.Run(file);
            Fill_Prod(powiaty, analysis, inputData);
            bmp.Save(@"..\output\" + Path.GetFileNameWithoutExtension(file) + ".png", ImageFormat.Png);
            bmp.Dispose();
        }

    }

    private static void Fill_Test(Model.Powiaty powiaty, Model.Analysis analysis)
    {
        foreach (string powiat in powiaty.coordinates.Keys)
            foreach (Point point in powiaty.coordinates[powiat])
                analysis.Run(point.X, point.Y, Color.Red);
    }

    private static void Fill_Prod(Model.Powiaty powiaty, Model.Analysis analysis, Model.I_InputData inputData)
    {
        var sb = new System.Text.StringBuilder();

        foreach (string powiat in inputData.data.Keys)
            if (powiaty.coordinates.ContainsKey(powiat))
                foreach (Point point in powiaty.coordinates[powiat])
                    analysis.Run(point.X, point.Y, inputData.data[powiat]);
            else 
                sb.Append(powiat + "\r\n");
    
        System.IO.File.WriteAllText("errors.txt", sb.ToString());
    }
}


