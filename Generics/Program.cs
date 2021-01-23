using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("adana");
            sehirler.Add("adana");
            sehirler.Add("adana");
            sehirler.Add("adana");
            sehirler.Add("adana");
            Console.WriteLine(sehirler.Count);
            //sehirler.Add("01");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("adana");
            sehirler2.Add("adana");
            sehirler2.Add("adana");
            sehirler2.Add("adana");
            sehirler2.Add("adana");
            sehirler2.Add("adana");
            sehirler2.Add("adana2");
            sehirler2.Add("adana2");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> // Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array; // mesela burada _array de ki boş yer [][][] olsun
            _array = new T[_array.Length + 1]; // burada ise yeni adresiyle bir artıyor sonuc [][][][] oluyor
            // _array dizimizi sıfırla başlatıp burada bir artırıyoruz fakat veri uçuyor
            // sebebi yeniden new yapmamız new yapınca yeni bir adres oluşuyor
            // bu yuzden geçici bir dizi olusturup _arrayi ona eşitleyerek adresimizi kaybetmemiş oluyoruz
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // burada geçici değişkendeki ilk değerlerimizi geri aldıgımızda
                // bir tane boş alan kalıyor
                // o alanada bu blok dışında item değerini atıyoruz
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }


    }
}
