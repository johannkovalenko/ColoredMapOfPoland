using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class InputDataPerThousand : I_InputData
    {
        public override Dictionary<string, Color> Run(string file)
        {
            var data = new Dictionary<string, Color>();
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] split = line.Split(';');

                string wojewodztwo  = split[0];
                string powiat       = split[1];
                float value           = float.Parse(split[2]);
                
                powiat = Duplicates(wojewodztwo, powiat);

                //if (value >= 1.0)
                    data[powiat] = GetColor(value);
            }
            
            return data;
        }

        private Color GetColor(double value)
        {
            if (value >= 5)
                return base.darkGreen;
            else if (value >= 0.5)
                return base.green;
            else if (value >= -0.5)
                return base.yellow;
            else if (value >= -5)
                return base.darkPink;
            else
                return base.red;
        }
    }
}