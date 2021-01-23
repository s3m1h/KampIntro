using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryID = 2;
            product1.ProductName = "324234";
            product1.UnitPrice = 500;

            Product product2 = new Product { 
                Id = 2,
                CategoryID = 5,
                ProductName = "kalem",
                UnitPrice = 45
            };
            // PascalCase // camelCase
            ProductManager productManager = new ProductManager(); // referans tip
            productManager.Add(product1);
            productManager.Add(product2);

            
            //int, double, bool ... değer tip --> değeri üzerinden atamalar olur bağlantılar kopar
            // diziler, class, abstract, interface class, referans tiplerdir...
            // ref out 

        }
    }
}
