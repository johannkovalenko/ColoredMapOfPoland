using System.Collections.Generic;
using System.IO;
using System;

namespace Model
{
    public class Strategies
    {
        private Dictionary<string, I_InputData> strategies = new Dictionary<string, I_InputData>() 
        {
            {"total_percent_2_10_20_30",    new InputDataTotalPercent()},
            {"total_50_100_200_500",        new InputDataValue()},
            {"rgb",                         new InputDataRGB()},
            {"perthousand",                 new InputDataPerThousand()}
        };

        public I_InputData Get(string file)
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            string[] split = fileName.Split("__");
            
            if (split.Length < 2)
                throw new Exception("STOP, Format does not exist: " + fileName);
            
            string key = split[1];

            if (strategies.ContainsKey(key))
                return strategies[key];
            else 
                throw new Exception("STOP, Format does not exist: " + fileName);
        }
    }
}