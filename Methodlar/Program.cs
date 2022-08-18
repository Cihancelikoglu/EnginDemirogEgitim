using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Bilgisayar";
            product1.Price = 10000;
            product1.Comment = "Lenovo y520";
            product1.Stock = 100;

            Product product2 = new Product();
            product2.Id = 1;
            product2.ProductName = "Klavye";
            product2.Price = 152;
            product2.Comment = "Logitech g203";
            product2.Stock = 50;

            Product[] products = new Product[] { product1, product2 };

            foreach (var item in products)
            {
                Console.WriteLine(item.ProductName + " " + item.Price + " " + item.Comment);
            }

            Console.WriteLine("---------Methods----------");

            //instance - Örnek Oluşturma
            //encapsulation - Kapsülleme - Düzensiz yapıları düzenli bir şekile sokmak

            SepetManager sepetManager = new SepetManager();
            sepetManager.Create(product1);
            sepetManager.Create(product2);

            sepetManager.Create2("Modem", "Asus", 15000);
        }
    }
}
