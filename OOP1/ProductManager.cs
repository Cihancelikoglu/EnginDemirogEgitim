using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + ":" + "Eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + ":" + "Güncellendi");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
