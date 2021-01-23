using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"erkan", "ahmet", "barış", "semih" };
            //Console.WriteLine(isimler[0]);
            //isimler[3] = "saef";
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // yukarıdaki diziden farklı cünkü new dediğimiz anda yeni adres açıldı


            List<string> isimler2 = new List<string> {"asef1", "asefesa2f","saef","saefesaf"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("add");
            Console.WriteLine(isimler2[4]);
        }
    }
}
