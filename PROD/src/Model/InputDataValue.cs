using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class InputDataValue : I_InputData
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
                int value           = int.Parse(split[2]);
                
                powiat = Duplicates(wojewodztwo, powiat);

                if (value >= 50)
                    data[powiat] = GetColor(value);
            }
            
            return data;
        }

        private Color GetColor(int value)
        {
            if (value >= 500)
                return base.darkGreen;
            else if (value >= 200)
                return base.green;
            else if (value >= 100)
                return base.yellow;
            else
                return base.turquois;
        }
    }
}