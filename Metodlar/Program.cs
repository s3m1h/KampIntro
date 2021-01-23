using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); // class örneği
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";


            Urun[] urunler = new Urun[] {urun1, urun2 };
            //Console.WriteLine(urunler[0].Aciklama);
            // type-safe -- tip güvenliği
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Aciklama);
            }
            Console.WriteLine("--------------MEthodlar------------------");
           
            //instance -- sepetManager örneği
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);

            //sepetManager.Ekle2("asef","asef",12);

        }
    }
}
// do not repeat yourself - DRY - Clead Code - Best Practice


