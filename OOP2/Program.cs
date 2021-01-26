using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "semih";
            musteri1.SoyAdi = "acar";
            musteri1.TcNo = "123124124";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "123123132";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123124124";



            //Gerçek müsteri - Tuzel Musteri
            //SOLID

            Musteri musteri3 = new GercekMusteri(); 
            // kalıtım işlemi burada devreye giriyor
            // musteriyi gerçek müsteriye kalıtım aldırdığımız için musteri gerçek musterinin 
            // adresini tutabilir hale geliyor
            Musteri musteri4 = new TuzelMusteri(); // kalıtım işlemi burada devreye giriyor
            // musteri sınıfı hem gerçek hemde tuzel müşterinin referansınız tutuyor

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
