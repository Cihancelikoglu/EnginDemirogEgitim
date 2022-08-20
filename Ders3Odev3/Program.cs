using System;
using System.Collections.Generic;

namespace Ders3Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Cihan";
            customer1.Surname = "Çelikoğlu";
            customer1.TotalShopping = 30;
            customer1.TotalPrice = 3000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Tülin";
            customer2.Surname = "Taşpınar";
            customer2.TotalShopping = 10;
            customer2.TotalPrice = 1000;

            CustomerManager customerManager = new CustomerManager();
            //------------------------------------// Generics List
            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer1);
            customerList.Add(customer2);
            //------------------------------------//


            foreach (var item in customerList)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
                customerManager.Add(item);//Customer Add
                Console.WriteLine("");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Müşteriler Listelendi...");
            foreach (var item2 in customerList)
            {
                Console.WriteLine("--------------------------------------------");
                customerManager.GetList(item2);//Customer List
                Console.WriteLine("");
            }

            Console.WriteLine("--------------------------------------------");
            customerManager.Update(customer2, 2);//Customer Update

            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------");
            customerManager.Delete(customer1, 1);//Customer Delete

        }
    }
}
