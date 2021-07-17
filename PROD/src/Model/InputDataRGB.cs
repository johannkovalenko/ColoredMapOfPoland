using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class InputDataRGB : I_InputData
    {
        public override void Run(string file)
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] split = line.Split(';');

                string wojewodztwo = split[0];
                string powiat = split[1];
                
                powiat = Duplicates(wojewodztwo, powiat);

                int r = int.Parse(split[2]);
                int g = int.Parse(split[3]);
                int b = int.Parse(split[4]);
                data[powiat] = Color.FromArgb(r, g, b);
            }
        }


    }
}