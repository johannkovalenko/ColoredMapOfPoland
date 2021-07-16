using System.Collections.Generic;
using System.Drawing;

namespace Model
{
    public class Powiaty
    {
        public readonly Dictionary<string, Point[]> coordinates = new Dictionary<string, Point[]>();

        public Powiaty()
        {
            Podkarpackie();
            Świętokrzyskie();
            Malopolska();
            Śląskie();
            Opolskie();
            Dolnośląskie();
            Lubuskie();
            Zachodniopomorskie();
            Pomorskie();
            Warmińsko_mazurskie();
            Podlaskie();
            Lubelskie();
            Kujawsko_pomorskie();
            Łódzkie();
            Wielkopolskie();
            Mazowieckie();
        }

        private void Malopolska()
        {
            coordinates["Tarnów"] = new Point[] { new Point(3200, 3680)};
            coordinates["tatrzański"] = new Point[] { new Point(2750, 4230)};
            coordinates["proszowicki"] = new Point[] { new Point(2890, 3520)};
            coordinates["krakowski"] = new Point[] { new Point(2650, 3560), new Point(2880, 3605)};
            coordinates["wielicki"] = new Point[] { new Point(2830, 3710)};
            coordinates["miechowski"] = new Point[] { new Point(2780, 3390)};
            coordinates["oświęcimski"] = new Point[] { new Point(2400, 3700)};
            coordinates["myślenicki"] = new Point[] { new Point(2740, 3840)};
            coordinates["tarnowski"] = new Point[] { new Point(3210, 3760)};
            coordinates["Kraków"] = new Point[] { new Point(2740, 3650)};
            coordinates["wadowicki"] = new Point[] { new Point(2530, 3770)};
            coordinates["chrzanowski"] = new Point[] { new Point(2480, 3600)};
            coordinates["Nowy Sącz"] = new Point[] { new Point(3080, 3990)};
            coordinates["bocheński"] = new Point[] { new Point(2950, 3740)};
            coordinates["olkuski"] = new Point[] { new Point(2570, 3420)};
            coordinates["nowosądecki"] = new Point[] { new Point(3150, 4010)};
            coordinates["dąbrowski"] = new Point[] { new Point(3210, 3515)};
            coordinates["suski"] = new Point[] { new Point(2580, 3920)};
            coordinates["limanowski"] = new Point[] { new Point(2880, 3920)};
            coordinates["gorlicki"] = new Point[] { new Point(3300, 4000)};
            coordinates["brzeski"] = new Point[] { new Point(3060, 3710)};
            coordinates["nowotarski"] = new Point[] { new Point(2710, 4080)};
        }

        private void Świętokrzyskie()
        {
            coordinates["buski"] = new Point[] { new Point(3140, 3340)};
            coordinates["jędrzejowski"] = new Point[] { new Point(2900, 3200)};
            coordinates["kazimierski"] = new Point[] { new Point(3000, 3500)};
            coordinates["Kielce"] = new Point[] { new Point(3040, 3040)};
            coordinates["kielecki"] = new Point[] { new Point(3120, 3090)};
            coordinates["konecki"] = new Point[] { new Point(2920, 2830)};
            coordinates["opatowski"] = new Point[] { new Point(3400, 3100)};
            coordinates["ostrowiecki"] = new Point[] { new Point(3400, 2970)};
            coordinates["pińczowski"] = new Point[] { new Point(3000, 3300)};
            coordinates["sandomierski"] = new Point[] { new Point(3490, 3200)};
            coordinates["skarżyski"] = new Point[] { new Point(3120, 2870)};
            coordinates["starachowicki"] = new Point[] { new Point(3260, 2900)};
            coordinates["staszowski"] = new Point[] { new Point(3340, 3300)};
            coordinates["włoszczowski"] = new Point[] { new Point(2700, 3050)};
        }

        private void Podkarpackie()
        {
            coordinates["bieszczadzki"] = new Point[] { new Point(3980, 4070)};
            coordinates["brzozowski"] = new Point[] { new Point(3720, 3930)};
            coordinates["dębicki"] = new Point[] { new Point(3400, 3660)};
            coordinates["jarosławski"] = new Point[] { new Point(4000, 3660)};
            coordinates["jasielski"] = new Point[] { new Point(3450, 3960)};
            coordinates["kolbuszowski"] = new Point[] { new Point(3570, 3500)};
            coordinates["Krosno"] = new Point[] { new Point(3570, 3930)};
            coordinates["krośnieński"] = new Point[] { new Point(3570, 4070)};
            coordinates["leski"] = new Point[] { new Point(3860, 4070)};
            coordinates["leżajski"] = new Point[] { new Point(3890, 3500)};
            coordinates["lubaczowski"] = new Point[] { new Point(4200, 3500)};
            coordinates["łańcucki"] = new Point[] { new Point(3800, 3660)};
            coordinates["mielecki"] = new Point[] { new Point(3400, 3500)};
            coordinates["niżański"] = new Point[] { new Point(3830, 3250)};
            coordinates["przemyski"] = new Point[] { new Point(3900, 3930)};
            coordinates["Przemyśl"] = new Point[] { new Point(4040, 3860)};
            coordinates["przeworski"] = new Point[] { new Point(3900, 3700)};
            coordinates["ropczycko-sędziszowski"] = new Point[] { new Point(3570, 3660)};
            coordinates["rzeszowski"] = new Point[] { new Point(3690, 3600)};
            coordinates["Rzeszów"] = new Point[] { new Point(3690, 3690)};
            coordinates["sanocki"] = new Point[] { new Point(3700, 4070)};
            coordinates["stalowowolski"] = new Point[] { new Point(3700, 3250)};
            coordinates["strzyżowski"] = new Point[] { new Point(3570, 3780)};
            coordinates["Tarnobrzeg"] = new Point[] { new Point(3550, 3250)};
            coordinates["tarnobrzeski"] = new Point[] { new Point(3580, 3300)};
        }

        private void Śląskie()
        {
            coordinates["będziński"] = new Point[] { new Point(2350, 3370), new Point(2450, 3470)};
            coordinates["bielski"] = new Point[] { new Point(2300, 3760)};
            coordinates["Bielsko-Biała"] = new Point[] { new Point(2300, 3830)};
            coordinates["bieruńsko-lędziński"] = new Point[] { new Point(2350, 3600)};
            coordinates["Bytom"] = new Point[] { new Point(2220, 3410)};
            coordinates["Chorzów"] = new Point[] { new Point(2270, 3460)};
            coordinates["cieszyński"] = new Point[] { new Point(2160, 3850)};
            coordinates["Częstochowa"] = new Point[] { new Point(2350, 3080)};
            coordinates["częstochowski"] = new Point[] { new Point(2500, 3080)};
            coordinates["Dąbrowa Górnicza"] = new Point[] { new Point(2400, 3420)};
            coordinates["Gliwice"] = new Point[] { new Point(2120, 3450)};
            coordinates["gliwicki"] = new Point[] { new Point(2040, 3450)};
            coordinates["Jastrzębie-Zdrój"] = new Point[] { new Point(2100, 3730)};
            coordinates["Jaworzno"] = new Point[] { new Point(2420, 3540)};
            coordinates["Katowice"] = new Point[] { new Point(2300, 3520)};
            coordinates["kłobucki"] = new Point[] { new Point(2200, 3000)};
            coordinates["lubliniecki"] = new Point[] { new Point(2150, 3150)};
            coordinates["mikołowski"] = new Point[] { new Point(2200, 3600)};
            coordinates["Mysłowice"] = new Point[] { new Point(2340, 3540)};
            coordinates["myszkowski"] = new Point[] { new Point(2400, 3230)};
            coordinates["Piekary Śląskie"] = new Point[] { new Point(2260, 3390)};
            coordinates["pszczyński"] = new Point[] { new Point(2240, 3700)};
            coordinates["raciborski"] = new Point[] { new Point(1900, 3600)};
            coordinates["Ruda Śląska"] = new Point[] { new Point(2220, 3500)};
            coordinates["rybnicki"] = new Point[] { new Point(2000, 3610), new Point(2140, 3590), new Point(2080, 3670)};
            coordinates["Rybnik"] = new Point[] { new Point(2070, 3610)};
            coordinates["Siemianowice Śląskie"] = new Point[] { new Point(2300, 3450)};
            coordinates["Sosnowiec"] = new Point[] { new Point(2370, 3480)};
            coordinates["Świętochłowice"] = new Point[] { new Point(2240, 3470)};
            coordinates["tarnogórski"] = new Point[] { new Point(2200, 3330)};
            coordinates["Tychy"] = new Point[] { new Point(2290, 3600)};
            coordinates["wodzisławski"] = new Point[] { new Point(2000, 3700)};
            coordinates["Zabrze"] = new Point[] { new Point(2180, 3450)};
            coordinates["zawierciański"] = new Point[] { new Point(2570, 3290)};
            coordinates["Żory"] = new Point[] { new Point(2140, 3660)};
            coordinates["żywiecki"] = new Point[] { new Point(2400, 3900)};
        }

        private void Opolskie()
        {
            coordinates["brzeski o."] = new Point[] { new Point(1570, 3070)};
            coordinates["głubczycki"] = new Point[] { new Point(1780, 3600)};
            coordinates["kędzierzyńsko-kozielski"] = new Point[] { new Point(1890, 3460)};
            coordinates["kluczborski"] = new Point[] { new Point(1870, 2890)};
            coordinates["krapkowicki"] = new Point[] { new Point(1810, 3340)};
            coordinates["namysłowski"] = new Point[] { new Point(1680, 2880)};
            coordinates["nyski"] = new Point[] { new Point(1490, 3330)};
            coordinates["oleski"] = new Point[] { new Point(2050, 2970)};
            coordinates["Opole"] = new Point[] { new Point(1780, 3180)};
            coordinates["opolski"] = new Point[] { new Point(1860, 3120)};
            coordinates["prudnicki"] = new Point[] { new Point(1650, 3400)};
            coordinates["strzelecki"] = new Point[] { new Point(1960, 3290)};
        }

        private void Dolnośląskie()
        {
            coordinates["bolesławiecki"] = new Point[] { new Point(680, 2680)};
            coordinates["dzierżoniowski"] = new Point[] { new Point(1220, 3120)};
            coordinates["głogowski"] = new Point[] { new Point(900, 2400)};
            coordinates["górowski"] = new Point[] { new Point(1110, 2430)};
            coordinates["jaworski"] = new Point[] { new Point(930, 2900)};
            coordinates["Jelenia Góra"] = new Point[] { new Point(760, 3010)};
            coordinates["jeleniogórski"] = new Point[] { new Point(680, 3000)};
            coordinates["kamiennogórski"] = new Point[] { new Point(880, 3110)};
            coordinates["kłodzki"] = new Point[] { new Point(1160, 3400)};
            coordinates["Legnica"] = new Point[] { new Point(960, 2770)};
            coordinates["legnicki"] = new Point[] { new Point(1040, 2770)};
            coordinates["lubański"] = new Point[] { new Point(550, 2850)};
            coordinates["lubiński"] = new Point[] { new Point(1020, 2600)};
            coordinates["lwówecki"] = new Point[] { new Point(680, 2880)};
            coordinates["milicki"] = new Point[] { new Point(1500, 2530)};
            coordinates["oleśnicki"] = new Point[] { new Point(1600, 2720)};
            coordinates["oławski"] = new Point[] { new Point(1500, 2960)};
            coordinates["polkowicki"] = new Point[] { new Point(860, 2570)};
            coordinates["strzeliński"] = new Point[] { new Point(1390, 3100)};
            coordinates["średzki d."] = new Point[] { new Point(1170, 2800)};
            coordinates["świdnicki"] = new Point[] { new Point(1090, 3000)};
            coordinates["trzebnicki"] = new Point[] { new Point(1330, 2630)};
            coordinates["Wałbrzych"] = new Point[] { new Point(1020, 3100)};
            coordinates["wałbrzyski"] = new Point[] { new Point(960, 3080)};
            coordinates["wołowski"] = new Point[] { new Point(1170, 2640)};
            coordinates["Wrocław"] = new Point[] { new Point(1350, 2840)};
            coordinates["wrocławski"] = new Point[] { new Point(1330, 2950)};
            coordinates["ząbkowicki"] = new Point[] { new Point(1300, 3260)};
            coordinates["zgorzelecki"] = new Point[] { new Point(490, 2700)};
            coordinates["złotoryjski"] = new Point[] { new Point(830, 2840)};
        }

        private void Lubuskie()
        {
            coordinates["gorzowski"] = new Point[] { new Point(380, 1600)};
            coordinates["Gorzów Wielkopolski"] = new Point[] { new Point(520, 1600)};
            coordinates["krośnieński l."] = new Point[] { new Point(430, 2120)};
            coordinates["międzyrzecki"] = new Point[] { new Point(700, 1770)};
            coordinates["nowosolski"] = new Point[] { new Point(730, 2340)};
            coordinates["słubicki"] = new Point[] { new Point(300, 1860)};
            coordinates["strzelecko-drezdenecki"] = new Point[] { new Point(770, 1480)};
            coordinates["sulęciński"] = new Point[] { new Point(490, 1790)};
            coordinates["świebodziński"] = new Point[] { new Point(650, 1970)};
            coordinates["wschowski"] = new Point[] { new Point(940, 2280)};
            coordinates["Zielona Góra"] = new Point[] { new Point(680, 2220)};
            coordinates["zielonogórski"] = new Point[] { new Point(760, 2100)};
            coordinates["żagański"] = new Point[] { new Point(630, 2460)};
            coordinates["żarski"] = new Point[] { new Point(400, 2380)};
        }

        private void Zachodniopomorskie()
        {
            coordinates["białogardzki"] = new Point[] { new Point(890, 640)};
            coordinates["choszczeński"] = new Point[] { new Point(700, 1300)};
            coordinates["drawski"] = new Point[] { new Point(860, 1000)};
            coordinates["goleniowski"] = new Point[] { new Point(360, 900)};
            coordinates["gryficki"] = new Point[] { new Point(520, 640)};
            coordinates["gryfiński"] = new Point[] { new Point(190, 1400)};
            coordinates["kamieński"] = new Point[] { new Point(360, 700)};
            coordinates["kołobrzeski"] = new Point[] { new Point(710, 540)};
            coordinates["Koszalin"] = new Point[] { new Point(990, 490)};
            coordinates["koszaliński"] = new Point[] { new Point(1120, 550)};
            coordinates["łobeski"] = new Point[] { new Point(660, 890)};
            coordinates["myśliborski"] = new Point[] { new Point(450, 1450)};
            coordinates["policki"] = new Point[] { new Point(160, 960)};
            coordinates["pyrzycki"] = new Point[] { new Point(390, 1280)};
            coordinates["sławieński"] = new Point[] { new Point(1160, 330)};
            coordinates["stargardzki"] = new Point[] { new Point(520, 1120)};
            coordinates["Szczecin"] = new Point[] { new Point(230, 1050)};
            coordinates["szczecinecki"] = new Point[] { new Point(1140, 840)};
            coordinates["świdwiński"] = new Point[] { new Point(840, 790)};
            coordinates["Świnoujście"] = new Point[] { new Point(210, 690), new Point(80, 720)};
            coordinates["wałecki"] = new Point[] { new Point(1040, 1190)};
        }

        private void Pomorskie()
        {
            coordinates["bytowski"] = new Point[] { new Point(1520, 540)};
            coordinates["chojnicki"] = new Point[] { new Point(1660, 760)};
            coordinates["człuchowski"] = new Point[] { new Point(1410, 840)};
            coordinates["Gdańsk"] = new Point[] { new Point(2100, 360)};
            coordinates["gdański"] = new Point[] { new Point(2080, 460)};
            coordinates["Gdynia"] = new Point[] { new Point(2050, 240)};
            coordinates["kartuski"] = new Point[] { new Point(1860, 400)};
            coordinates["kościerski"] = new Point[] { new Point(1790, 600)};
            coordinates["kwidzyński"] = new Point[] { new Point(2290, 850)};
            coordinates["lęborski"] = new Point[] { new Point(1680, 200)};
            coordinates["malborski"] = new Point[] { new Point(2300, 570)};
            coordinates["nowodworski p."] = new Point[] { new Point(2330, 430)};
            coordinates["pucki"] = new Point[] { new Point(1940, 50), new Point(2187, 165)};
            coordinates["Słupsk"] = new Point[] { new Point(1360, 280)};
            coordinates["słupski"] = new Point[] { new Point(1490, 270)};
            coordinates["Sopot"] = new Point[] { new Point(2073, 305)};
            coordinates["starogardzki"] = new Point[] { new Point(2000, 750)};
            coordinates["sztumski"] = new Point[] { new Point(2400, 690)};
            coordinates["tczewski"] = new Point[] { new Point(2170, 660)};
            coordinates["wejherowski"] = new Point[] { new Point(1860, 200)};
        }

        private void Warmińsko_mazurskie()
        {
            coordinates["bartoszycki"] = new Point[] { new Point(3050, 420)};
            coordinates["braniewski"] = new Point[] { new Point(2730, 400)};
            coordinates["działdowski"] = new Point[] { new Point(2730, 1180)};
            coordinates["Elbląg"] = new Point[] { new Point(2480, 510)};
            coordinates["elbląski"] = new Point[] { new Point(2550, 570)};
            coordinates["ełcki"] = new Point[] { new Point(3850, 790)};
            coordinates["giżycki"] = new Point[] { new Point(3600, 630)};
            coordinates["gołdapski"] = new Point[] { new Point(3820, 440)};
            coordinates["iławski"] = new Point[] { new Point(2520, 890)};
            coordinates["kętrzyński"] = new Point[] { new Point(3370, 500)};
            coordinates["lidzbarski"] = new Point[] { new Point(2930, 530)};
            coordinates["mrągowski"] = new Point[] { new Point(3360, 770)};
            coordinates["nidzicki"] = new Point[] { new Point(2980, 1120)};
            coordinates["nowomiejski"] = new Point[] { new Point(2550, 1070)};
            coordinates["olecki"] = new Point[] { new Point(3880, 610)};
            coordinates["Olsztyn"] = new Point[] { new Point(2960, 800)};
            coordinates["olsztyński"] = new Point[] { new Point(3070, 750)};
            coordinates["ostródzki"] = new Point[] { new Point(2730, 830)};
            coordinates["piski"] = new Point[] { new Point(3620, 900)};
            coordinates["szczycieński"] = new Point[] { new Point(3210, 1000)};
            coordinates["węgorzewski"] = new Point[] { new Point(3570, 480)};
        }

        private void Podlaskie()
        {
            coordinates["augustowski"] = new Point[] { new Point(4170, 780)};
            coordinates["białostocki"] = new Point[] { new Point(4340, 1320)};
            coordinates["Białystok"] = new Point[] { new Point(4220, 1300)};
            coordinates["bielski p."] = new Point[] { new Point(4140, 1590)};
            coordinates["grajewski"] = new Point[] { new Point(3880, 960)};
            coordinates["hajnowski"] = new Point[] { new Point(4410, 1610)};
            coordinates["kolneński"] = new Point[] { new Point(3680, 1110)};
            coordinates["Łomża"] = new Point[] { new Point(3710, 1280)};
            coordinates["łomżyński"] = new Point[] { new Point(3780, 1250)};
            coordinates["moniecki"] = new Point[] { new Point(4040, 1080)};
            coordinates["sejneński"] = new Point[] { new Point(4270, 570)};
            coordinates["siemiatycki"] = new Point[] { new Point(4070, 1800)};
            coordinates["sokólski"] = new Point[] { new Point(4320, 1010)};
            coordinates["suwalski"] = new Point[] { new Point(4020, 500)};
            coordinates["Suwałki"] = new Point[] { new Point(4110, 570)};
            coordinates["wysokomazowiecki"] = new Point[] { new Point(3940, 1470)};
            coordinates["zambrowski"] = new Point[] { new Point(3790, 1400)};
        }

        private void Lubelskie()
        {
            coordinates["bialski"] = new Point[] { new Point(4290, 2230)};
            coordinates["Biała Podlaska"] = new Point[] { new Point(4210, 2150)};
            coordinates["biłgorajski"] = new Point[] { new Point(4050, 3340)};
            coordinates["Chełm"] = new Point[] { new Point(4380, 2835)};
            coordinates["chełmski"] = new Point[] { new Point(4450, 2870)};
            coordinates["hrubieszowski"] = new Point[] { new Point(4530, 3100)};
            coordinates["janowski"] = new Point[] { new Point(3890, 3150)};
            coordinates["krasnostawski"] = new Point[] { new Point(4200, 2950)};
            coordinates["kraśnicki"] = new Point[] { new Point(3740, 3000)};
            coordinates["lubartowski"] = new Point[] { new Point(3910, 2530)};
            coordinates["lubelski"] = new Point[] { new Point(3840, 2800)};
            coordinates["Lublin"] = new Point[] { new Point(3950, 2760)};
            coordinates["łęczyński"] = new Point[] { new Point(4130, 2700)};
            coordinates["łukowski"] = new Point[] { new Point(3780, 2260)};
            coordinates["opolski l."] = new Point[] { new Point(3680, 2820)};
            coordinates["parczewski"] = new Point[] { new Point(4160, 2450)};
            coordinates["puławski"] = new Point[] { new Point(3700, 2620)};
            coordinates["radzyński"] = new Point[] { new Point(3990, 2330)};
            coordinates["rycki"] = new Point[] { new Point(3670, 2440)};
            coordinates["świdnicki l."] = new Point[] { new Point(4050, 2800)};
            coordinates["tomaszowski l."] = new Point[] { new Point(4420, 3330)};
            coordinates["włodawski"] = new Point[] { new Point(4310, 2540)};
            coordinates["zamojski"] = new Point[] { new Point(4350, 3140)};
            coordinates["Zamość"] = new Point[] { new Point(4265, 3160)};
        }

        private void Kujawsko_pomorskie()
        {
            coordinates["aleksandrowski"] = new Point[] { new Point(2160, 1550)};
            coordinates["brodnicki"] = new Point[] { new Point(2480, 1190)};
            coordinates["bydgoski"] = new Point[] { new Point(1790, 1180)};
            coordinates["Bydgoszcz"] = new Point[] { new Point(1840, 1300)};
            coordinates["chełmiński"] = new Point[] { new Point(2050, 1180)};
            coordinates["golubsko-dobrzyński"] = new Point[] { new Point(2300, 1330)};
            coordinates["Grudziądz"] = new Point[] { new Point(2170, 1050)};
            coordinates["grudziądzki"] = new Point[] { new Point(2290, 1040)};
            coordinates["inowrocławski"] = new Point[] { new Point(1950, 1540)};
            coordinates["lipnowski"] = new Point[] { new Point(2420, 1540)};
            coordinates["mogileński"] = new Point[] { new Point(1830, 1680)};
            coordinates["nakielski"] = new Point[] { new Point(1600, 1320)};
            coordinates["radziejowski"] = new Point[] { new Point(2090, 1710)};
            coordinates["rypiński"] = new Point[] { new Point(2460, 1380)};
            coordinates["sępoleński"] = new Point[] { new Point(1600, 1080)};
            coordinates["świecki"] = new Point[] { new Point(2040, 1000)};
            coordinates["Toruń"] = new Point[] { new Point(2100, 1390)};
            coordinates["toruński"] = new Point[] { new Point(2080, 1300)};
            coordinates["tucholski"] = new Point[] { new Point(1790, 970)};
            coordinates["wąbrzeski"] = new Point[] { new Point(2250, 1200)};
            coordinates["Włocławek"] = new Point[] { new Point(2320, 1670)};
            coordinates["włocławski"] = new Point[] { new Point(2280, 1790), new Point(2330, 1630)};
            coordinates["żniński"] = new Point[] { new Point(1680, 1540)};
        }

        private void Łódzkie()
        {
            coordinates["bełchatowski"] = new Point[] { new Point(2410, 2660)};
            coordinates["brzeziński"] = new Point[] { new Point(2660, 2290)};
            coordinates["kutnowski"] = new Point[] { new Point(2470, 1970)};
            coordinates["łaski"] = new Point[] { new Point(2330, 2500)};
            coordinates["łęczycki"] = new Point[] { new Point(2340, 2090)};
            coordinates["łowicki"] = new Point[] { new Point(2690, 2070)};
            coordinates["łódzki wschodni"] = new Point[] { new Point(2570, 2420)};
            coordinates["Łódź"] = new Point[] { new Point(2500, 2340)};
            coordinates["opoczyński"] = new Point[] { new Point(2850, 2610)};
            coordinates["pabianicki"] = new Point[] { new Point(2410, 2420)};
            coordinates["pajęczański"] = new Point[] { new Point(2290, 2800)};
            coordinates["piotrkowski"] = new Point[] { new Point(2600, 2700)};
            coordinates["Piotrków Trybunalski"] = new Point[] { new Point(2600, 2610)};
            coordinates["poddębicki"] = new Point[] { new Point(2250, 2240)};
            coordinates["radomszczański"] = new Point[] { new Point(2550, 2880)};
            coordinates["rawski"] = new Point[] { new Point(2910, 2330)};
            coordinates["sieradzki"] = new Point[] { new Point(2090, 2480)};
            coordinates["Skierniewice"] = new Point[] { new Point(2820, 2190)};
            coordinates["skierniewicki"] = new Point[] { new Point(2760, 2250)};
            coordinates["tomaszowski"] = new Point[] { new Point(2770, 2460)};
            coordinates["wieluński"] = new Point[] { new Point(2080, 2750)};
            coordinates["wieruszowski"] = new Point[] { new Point(1930, 2680)};
            coordinates["zduńskowolski"] = new Point[] { new Point(2240, 2410)};
            coordinates["zgierski"] = new Point[] { new Point(2460, 2230)};
        }

        private void Wielkopolskie()
        {
            coordinates["chodzieski"] = new Point[] { new Point(1340, 1430)};
            coordinates["czarnkowsko-trzcianecki"] = new Point[] { new Point(1050, 1470)};
            coordinates["gnieźnieński"] = new Point[] { new Point(1590, 1730)};
            coordinates["gostyński"] = new Point[] { new Point(1370, 2280)};
            coordinates["grodziski w."] = new Point[] { new Point(1030, 2020)};
            coordinates["jarociński"] = new Point[] { new Point(1580, 2180)};
            coordinates["kaliski"] = new Point[] { new Point(1900, 2280)};
            coordinates["Kalisz"] = new Point[] { new Point(1860, 2360)};
            coordinates["kępiński"] = new Point[] { new Point(1780, 2720)};
            coordinates["kolski"] = new Point[] { new Point(2170, 1980)};
            coordinates["Konin"] = new Point[] { new Point(1940, 1950)};
            coordinates["koniński"] = new Point[] { new Point(1950, 1850)};
            coordinates["kościański"] = new Point[] { new Point(1200, 2100)};
            coordinates["krotoszyński"] = new Point[] { new Point(1550, 2350)};
            coordinates["leszczyński"] = new Point[] { new Point(1220, 2250)};
            coordinates["Leszno"] = new Point[] { new Point(1150, 2290)};
            coordinates["międzychodzki"] = new Point[] { new Point(870, 1700)};
            coordinates["nowotomyski"] = new Point[] { new Point(930, 1900)};
            coordinates["obornicki"] = new Point[] { new Point(1280, 1630)};
            coordinates["ostrowski w."] = new Point[] { new Point(1750, 2420)};
            coordinates["ostrzeszowski"] = new Point[] { new Point(1820, 2590)};
            coordinates["pilski"] = new Point[] { new Point(1310, 1290)};
            coordinates["pleszewski"] = new Point[] { new Point(1740, 2230)};
            coordinates["Poznań"] = new Point[] { new Point(1300, 1850)};
            coordinates["poznański"] = new Point[] { new Point(1450, 1850)};
            coordinates["rawicki"] = new Point[] { new Point(1310, 2440)};
            coordinates["słupecki"] = new Point[] { new Point(1750, 1920)};
            coordinates["szamotulski"] = new Point[] { new Point(1100, 1700)};
            coordinates["średzki"] = new Point[] { new Point(1490, 2010)};
            coordinates["śremski"] = new Point[] { new Point(1370, 2120)};
            coordinates["turecki"] = new Point[] { new Point(2030, 2150)};
            coordinates["wągrowiecki"] = new Point[] { new Point(1470, 1520)};
            coordinates["wolsztyński"] = new Point[] { new Point(950, 2110)};
            coordinates["wrzesiński"] = new Point[] { new Point(1620, 1940)};
            coordinates["złotowski"] = new Point[] { new Point(1320, 1090)};
        }

        private void Mazowieckie()
        {
            coordinates["białobrzeski"] = new Point[] { new Point(3190, 2470)};
            coordinates["ciechanowski"] = new Point[] { new Point(3050, 1500)};
            coordinates["garwoliński"] = new Point[] { new Point(3520, 2300)};
            coordinates["gostyniński"] = new Point[] { new Point(2480, 1860)};
            coordinates["grodziski"] = new Point[] { new Point(3020, 2090)};
            coordinates["grójecki"] = new Point[] { new Point(3150, 2300)};
            coordinates["kozienicki"] = new Point[] { new Point(3390, 2460)};
            coordinates["legionowski"] = new Point[] { new Point(3200, 1840)};
            coordinates["lipski"] = new Point[] { new Point(3500, 2810)};
            coordinates["łosicki"] = new Point[] { new Point(4070, 2000)};
            coordinates["makowski"] = new Point[] { new Point(3310, 1450)};
            coordinates["miński"] = new Point[] { new Point(3520, 2020)};
            coordinates["mławski"] = new Point[] { new Point(2910, 1370)};
            coordinates["nowodworski"] = new Point[] { new Point(3040, 1850)};
            coordinates["ostrołęcki"] = new Point[] { new Point(3420, 1220)};
            coordinates["Ostrołęka"] = new Point[] { new Point(3490, 1350)};
            coordinates["ostrowski"] = new Point[] { new Point(3650, 1580)};
            coordinates["otwocki"] = new Point[] { new Point(3370, 2100)};
            coordinates["piaseczyński"] = new Point[] { new Point(3220, 2160)};
            coordinates["Płock"] = new Point[] { new Point(2613, 1760)};
            coordinates["płocki"] = new Point[] { new Point(2700, 1715)};
            coordinates["płoński"] = new Point[] { new Point(2900, 1700)};
            coordinates["pruszkowski"] = new Point[] { new Point(3140, 2050)};
            coordinates["przasnyski"] = new Point[] { new Point(3160, 1290)};
            coordinates["przysuski"] = new Point[] { new Point(3020, 2620)};
            coordinates["pułtuski"] = new Point[] { new Point(3220, 1650)};
            coordinates["Radom"] = new Point[] { new Point(3280, 2640)};
            coordinates["radomski"] = new Point[] { new Point(3300, 2730)};
            coordinates["Siedlce"] = new Point[] { new Point(3800, 2050)};
            coordinates["siedlecki"] = new Point[] { new Point(3880, 2000)};
            coordinates["sierpecki"] = new Point[] { new Point(2620, 1530)};
            coordinates["sochaczewski"] = new Point[] { new Point(2850, 1980)};
            coordinates["sokołowski"] = new Point[] { new Point(3830, 1790)};
            coordinates["szydłowiecki"] = new Point[] { new Point(3160, 2739)};
            coordinates["Warszawa"] = new Point[] { new Point(3320, 1990)};
            coordinates["warszawski zachodni"] = new Point[] { new Point(3080, 1970)};
            coordinates["węgrowski"] = new Point[] { new Point(3630, 1800)};
            coordinates["wołomiński"] = new Point[] { new Point(3370, 1880)};
            coordinates["wyszkowski"] = new Point[] { new Point(3430, 1660)};
            coordinates["zwoleński"] = new Point[] { new Point(3500, 2670)};
            coordinates["żuromiński"] = new Point[] { new Point(2690, 1360)};
            coordinates["żyrardowski"] = new Point[] { new Point(2930, 2150)};
        }
    }
}