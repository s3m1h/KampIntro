using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum --> bunlar değer tiplerdir
            int sayi1 = 10;
            int sayi2 =  20;
            sayi1 = sayi2;
            sayi2 = 100;

            // tek tek yazalım ne yukarıdaki kodların ne oldugunu
            // önce sayi1 e 10 atanmış
            // sonra sayi2 ye 20 atanmış
            // sayi1 e sayi2 atanmış artık sayi1 in değeri 20 oldu
            // sayi2 ye 100 atanmış
            // sayi1 in değeri 20 olarak kalır sebebi değer tiplerdir

            Console.WriteLine(sayi1);
            //--------------------------------------------------------------
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar1[0] = 1000;

            // sayilar1 dizisine sayilar2 dizisini atıyoruz
            // sayilar1in sıfırıncı elemanına 1000 değerini atıyoruz
            // sayilar1in birinci elemanı 1000 olur sebebi diziyi new yaparak referans hale getirdik
            // yani bellek adresi atanıyor, yani sayilar1 ve sayilar2nin adresi var
            // sayilar1e sayilar2 atanırsa eğer artık sayilar2nin adreside sayilar1in adresiyle aynı oluyor
            // bu durumda sayilar1in adresi ve değerleri uçuyor(çöp toplayıcı(garbage collector) tarafından bellekten atılır)
            

            Console.WriteLine(sayilar1[0]);
            ///  değer tiplerde herşey bellekte stack alanında çalışıyor
            ///  ama referans tipler hem stack alanı hemde heap alanında çalışıyor
            ///  
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "semih";

            person2 = person1;
            person1.FirstName = "derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "salih";

            Employee employee = new Employee();

            Person person3 = customer; //person3 customerin adresini tutuyor
            Console.WriteLine(person3.FirstName);

        }
    }
    class Person//kişi
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person//müşteri
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee:Person // person sınıfından kalıtım aldırdık
    {
        public int EmployeeNumber { get; set; }

    }
}
