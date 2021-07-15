using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class InputData
    {
        public Dictionary<string, Color> data = new Dictionary<string, Color>();

        public InputData()
        {
            string[] lines = File.ReadAllLines(@"..\input\data.txt");

            foreach (string line in lines)
            {
                string[] split = line.Split(';');
                int r = int.Parse(split[1]);
                int g = int.Parse(split[2]);
                int b = int.Parse(split[3]);
                data[split[0]] = Color.FromArgb(r, g, b);
            }
        }
    }
}