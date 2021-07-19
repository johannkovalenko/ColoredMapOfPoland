using System.Collections.Generic;
using System.Drawing;

namespace Model
{
    public abstract class I_InputData
    {
        public abstract Dictionary<string, Color> Run(string file);

        protected Color darkGreen  = Color.FromArgb(34, 177, 76);
        protected Color green      = Color.FromArgb(0, 255, 0);
        protected Color yellow     = Color.FromArgb(255, 255, 0);
        protected Color turquois   = Color.FromArgb(0, 255, 255);

        protected Color darkPink    = Color.FromArgb(255, 0, 128);
        protected Color pink        = Color.FromArgb(255, 0, 255);
        protected Color rose        = Color.FromArgb(255, 128, 192);
        protected Color lightRose   = Color.FromArgb(255, 128, 255);

        protected Color red         = Color.FromArgb(255, 0, 0);
        
        protected string Duplicates(string wojewodztwo, string powiat)
        {
            if (wojewodztwo == "opolskie" && powiat == "brzeski")
                return "brzeski o.";
            else if (wojewodztwo == "dolnośląskie" && powiat == "średzki")
                return "średzki d.";
            else if (wojewodztwo == "lubuskie" && powiat == "krośnieński")
                return "krośnieński l.";
            else if (wojewodztwo == "pomorskie" && powiat == "nowodworski")
                return "nowodworski p.";
            else if (wojewodztwo == "podlaskie" && powiat == "bielski")
                return "bielski p.";
            else if (wojewodztwo == "lubelskie" && powiat == "opolski")
                return "opolski l.";
            else if (wojewodztwo == "lubelskie" && powiat == "świdnicki")
                return "świdnicki l.";
            else if (wojewodztwo == "lubelskie" && powiat == "tomaszowski")
                return "tomaszowski l.";               
            else if (wojewodztwo == "wielkopolskie" && powiat == "grodziski")
                return "grodziski w.";
            else if (wojewodztwo == "wielkopolskie" && powiat == "ostrowski")
                return "ostrowski w.";
            else 
                return powiat;      
        }
    }
}