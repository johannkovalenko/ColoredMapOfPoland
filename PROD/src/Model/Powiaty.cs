using System.Collections.Generic;
using System.Drawing;

namespace Model
{
    public class Powiaty
    {
        public readonly Dictionary<string, Point> coordinates = new Dictionary<string, Point>(); 
        public Powiaty()
        {
            Podkarpackie();
            Świętokrzyskie();
            Malopolska();
        }

        private void Malopolska()
        {
            coordinates.Add("Tarnów", new Point(3200, 3680));
            coordinates.Add("tatrzański", new Point(2750, 4230));
            coordinates.Add("proszowicki", new Point(2890, 3520));
            coordinates.Add("krakowski", new Point(2650, 3560));
            coordinates.Add("krakowski2", new Point(2880, 3605));
            coordinates.Add("wielicki", new Point(2830, 3710));
            coordinates.Add("miechowski", new Point(2780, 3390));
            coordinates.Add("oświęcimski", new Point(2400, 3700));
            coordinates.Add("myślenicki", new Point(2740, 3840));
            coordinates.Add("tarnowski", new Point(3210, 3760));
            coordinates.Add("Kraków", new Point(2740, 3650));
            coordinates.Add("wadowicki", new Point(2530, 3770));
            coordinates.Add("chrzanowski", new Point(2480, 3600));
            coordinates.Add("Nowy Sącz", new Point(3080, 3990));
            coordinates.Add("bocheński", new Point(2950, 3740));
            coordinates.Add("olkuski", new Point(2570, 3420));
            coordinates.Add("nowosądecki", new Point(3150, 4010));
            coordinates.Add("dąbrowski", new Point(3210, 3515));
            coordinates.Add("suski", new Point(2580, 3920));
            coordinates.Add("limanowski", new Point(2880, 3920));
            coordinates.Add("gorlicki", new Point(3300, 4000));
            coordinates.Add("brzeski", new Point(3060, 3710));
            coordinates.Add("nowotarski", new Point(2710, 4080));
        }

        private void Świętokrzyskie()
        {
            coordinates.Add("buski", new Point(3140, 3340));
            coordinates.Add("jędrzejowski", new Point(2900, 3200));
            coordinates.Add("kazimierski", new Point(3000, 3500));
            coordinates.Add("Kielce", new Point(3040, 3040));
            coordinates.Add("kielecki", new Point(3120, 3090));
            coordinates.Add("konecki", new Point(2920, 2830));
            coordinates.Add("opatowski", new Point(3400, 3100));
            coordinates.Add("ostrowiecki", new Point(3400, 2970));
            coordinates.Add("pińczowski", new Point(3000, 3300));
            coordinates.Add("sandomierski", new Point(3490, 3200));
            coordinates.Add("skarżyski", new Point(3120, 2870));
            coordinates.Add("starachowicki", new Point(3260, 2900));
            coordinates.Add("staszowski", new Point(3340, 3300));
            coordinates.Add("włoszczowski", new Point(2700, 3050));
        }

        private void Podkarpackie()
        {
            coordinates.Add("bieszczadzki", new Point(3980, 4070));
            coordinates.Add("brzozowski", new Point(3720, 3930));
            coordinates.Add("dębicki", new Point(3400, 3660));
            coordinates.Add("jarosławski", new Point(4000, 3660));
            coordinates.Add("jasielski", new Point(3450, 3960));
            coordinates.Add("kolbuszowski", new Point(3570, 3500));
            coordinates.Add("Krosno", new Point(3570, 3930));
            coordinates.Add("krośnieński", new Point(3570, 4070));
            coordinates.Add("leski", new Point(3860, 4070));
            coordinates.Add("leżajski", new Point(3890, 3500));
            coordinates.Add("lubaczowski", new Point(4200, 3500));
            coordinates.Add("łańcucki", new Point(3800, 3660));
            coordinates.Add("mielecki", new Point(3400, 3500));
            coordinates.Add("niżański", new Point(3830, 3250));
            coordinates.Add("przemyski", new Point(3900, 3930));
            coordinates.Add("Przemyśl", new Point(4040, 3860));
            coordinates.Add("przeworski", new Point(3900, 3700));
            coordinates.Add("ropczycko-sędziszowski", new Point(3570, 3660));
            coordinates.Add("rzeszowski", new Point(3690, 3600));
            coordinates.Add("Rzeszów", new Point(3690, 3690));
            coordinates.Add("sanocki", new Point(3700, 4070));
            coordinates.Add("stalowowolski", new Point(3700, 3250));
            coordinates.Add("strzyżowski", new Point(3570, 3780));
            coordinates.Add("Tarnobrzeg", new Point(3550, 3250));
            coordinates.Add("tarnobrzeski", new Point(3580, 3300));

        }
    }
}