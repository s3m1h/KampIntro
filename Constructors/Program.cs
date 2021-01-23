using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="semih",LastName="acar",City= "adana"};
            Customer customer3 = new Customer();
            customer3.FirstName = "çağlar";
            customer3.LastName = "acar";
            customer3.City = "kozan";
            // yukarıdaki iki kullanım kullanılabilir sorun çıkmaz 
            // ama aşağıdaki kullanımda constructor parametresi vermemiz gerekli
            // aynı method gibi çalışıyor
            // parametresi olmayan costructor default constructor olmuş oluyor


            Customer customer2 = new Customer(2,"asef","asef","seafsae");
            Console.WriteLine(customer2.FirstName);

            


        }

    }
    class Customer
    {
        public Customer()
        {

        }
        // constructors oluşturmak için ctor tab tab yapıyoruz
        // default constructors
        public Customer(int id, string firstName, string lastName, string city)
        {
            // sınıftan referans oluşturdugumuzda ilk çalışan blok burasıdır
            // yoksa bile default olarak constructor vardır
            Console.WriteLine("yapıcı blok çalıştı");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
