using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem islem = new DortIslem();
            //islem.Topla(5,5);
            //islem.Topla(5,6);

            DortIslem islem2 = new DortIslem();
            islem2.sayi1 = 5;
            islem2.sayi2 = 10;

            int sonuc = islem2.sayi1 + islem2.sayi2;
            Console.WriteLine(sonuc);
        }
    }
}
