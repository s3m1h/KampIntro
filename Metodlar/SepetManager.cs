using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {   
        //naming convention - isimlendirme kuralı
        //syntax- yazım şekli
        public void Ekle(Urun ur)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :"+ ur.Adi + ur.Fiyati);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler " + urunAdi);
        }
    }
}
