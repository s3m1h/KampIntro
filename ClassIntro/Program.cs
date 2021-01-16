using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kurs kurs1 = new Kurs();
            //kurs1.KursAdi = "c#";
            //kurs1.Egitmen = "engin demirog";
            //kurs1.IzlenmeOrani = 68;

            //Kurs kurs2 = new Kurs();
            //kurs1.KursAdi = "python";
            //kurs2.Egitmen = "semih acar";
            //kurs2.IzlenmeOrani = 168;
            
            //Kurs kurs3 = new Kurs();
            //kurs3.KursAdi = "java";
            //kurs3.Egitmen = "engin demirog";
            //kurs3.IzlenmeOrani = 1168;

            //// kurs sınıfından bir array tanımladık
            //Kurs[] kurslar = new Kurs[] {kurs2, kurs1, kurs3};

            //foreach (var kurs in kurslar)
            //{
            //    Console.WriteLine(kurs.Egitmen);
            //}

            Bilgisayar pc1 = new Bilgisayar();
            pc1.adi = "msi";
            pc1.modeli = "GL62 QC";
            pc1.ram = 8048;
            pc1.ekranKarti = 4024;
            pc1.hdd = "1tb";


            Bilgisayar pc2 = new Bilgisayar();
            pc2.adi = "asus gameging";
            pc2.modeli = "GL62 QC";
            pc2.ram = 8048;
            pc2.ekranKarti = 4024;
            pc2.hdd = "5tb";

            Bilgisayar pc3 = new Bilgisayar();
            pc3.adi = "Hp fön makinesi";
            pc3.modeli = "GL62 QC";
            pc3.ram = 8048;
            pc3.ekranKarti = 4024;
            pc3.hdd = "2tb";

            Bilgisayar[] bilgisayarlar = new Bilgisayar[] { pc1, pc2, pc3  };

            foreach (var item in bilgisayarlar)
            {
                Console.WriteLine(item.adi+ " "+ item.modeli + " "+item.ram);
            }
        }
    }

    class Kurs
    {   
        // prop tab tab
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Bilgisayar
    {
        public string adi { get; set; }
        public string modeli { get; set; }
        public int ram { get; set; }
        public string hdd { get; set; }
        public int ekranKarti { get; set; }
    }

}
