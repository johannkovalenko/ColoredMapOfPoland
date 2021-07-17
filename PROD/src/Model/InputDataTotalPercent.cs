using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class InputDataTotalPercent : I_InputData
    {
        public override void Run(string file)
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] split = line.Split(';');

                string wojewodztwo  = split[0];
                string powiat       = split[1];
                int total           = int.Parse(split[2]);
                int percent         = int.Parse(split[3]);
                
                powiat = Duplicates(wojewodztwo, powiat);

                if (total > 1 && percent > 1)
                    data[powiat] = GetColor(percent);
            }
        }

        private Color GetColor(int percent)
        {
            if (percent >= 30)
                return base.darkGreen;
            else if (percent >= 20)
                return base.green;
            else if (percent >= 10)
                return base.yellow;
            else
                return base.turquois;
        }
    }
}