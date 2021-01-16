using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30
            // int, decimal,boolean .. -- değer tip
            // array, class, interface --> referans tip

            int[] sayilar1 = new int[] { 1,2,3};
            int[] sayilar2 = new int[] { 1,2,3};

            // değertipler stack alanında 
            // referans tipler heapte
            // değertipler stack alanında gerçekleşiyor sayi1 = 10, sayi2 = 30
            // sayi1in değeri eşittir 10 diye okuruz
            // sayi1in değeri eşittir sayi2 ise sayi1 = sayi2 ise 
            // sayi1 = 30dur
            //---------------------------------------------------------------
            //sayilar dizisi tanımladığımızda ve onu new yaptıgımızda heap alanında oluşturur
            // new bellekten bir adres oluşturur
            // sayilar1in referans numarası eşittir sayilar2nin referans numarası diye okunur
            //referans tipler adres kopyalaması yapar
            //

        }
    }
}
