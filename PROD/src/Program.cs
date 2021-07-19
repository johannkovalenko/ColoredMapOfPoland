using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

static class Program
{
    static void Main()
    {   
        var powiaty = new Model.Powiaty();  
        var analysis    = new Model.Analysis();
        var strategies = new Model.Strategies();

        foreach (string file in Directory.GetFiles("..\\input"))
        { 
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Model.I_BMP bmp = new Model.BMP_Test();
            analysis.UpdateBMP(bmp);
            
            Model.I_InputData inputData = strategies.Get(file);
            Dictionary<string, Color> data = inputData.Run(file);
            Fill_Prod(data, powiaty, analysis, inputData);

            bmp.Save(file);

            stopwatch.Stop();

            File.AppendAllText("debug.txt", stopwatch.Elapsed.TotalMilliseconds.ToString() + "\r\n");
        }

    }

    private static void Fill_Test(Model.Powiaty powiaty, Model.Analysis analysis)
    {
        foreach (string powiat in powiaty.coordinates.Keys)
            foreach (Point point in powiaty.coordinates[powiat])
                analysis.Run(point.X, point.Y, Color.Red);
    }

    private static void Fill_Prod(Dictionary<string, Color> data, Model.Powiaty powiaty, Model.Analysis analysis, Model.I_InputData inputData)
    {
        var sb = new System.Text.StringBuilder();

        foreach (string powiat in data.Keys)
            if (powiaty.coordinates.ContainsKey(powiat))
                foreach (Point point in powiaty.coordinates[powiat])
                    analysis.Run(point.X, point.Y, data[powiat]);
            else 
                sb.Append(powiat + "\r\n");
    
        System.IO.File.WriteAllText("errors.txt", sb.ToString());
    }
}


