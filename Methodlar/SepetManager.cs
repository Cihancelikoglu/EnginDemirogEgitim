using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        //Naming Convention - İsimlendirme Kuralı
        public void Create(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.ProductName);
        }

        public void Create2(string productName, string Comment, double Price)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);
        }
    }
}
