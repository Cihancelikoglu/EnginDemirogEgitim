using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3Odev3
{
    class CustomerManager
    {
        public void GetList(Customer customer)
        {
            Console.WriteLine("Muşteri Numarası: " + customer.Id);
            Console.WriteLine("Ad: " + customer.Name);
            Console.WriteLine("Soyad: " + customer.Surname);
            Console.WriteLine("Total Alışveriş: " + customer.TotalShopping);
            Console.WriteLine("Total Fiyat: " + customer.TotalPrice);
        }
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " Müşteri Numarasıyla Eklendi...");
        }
        public void Update(Customer customer, int id)
        {
            if (customer.Id == id)
            {
                Console.WriteLine(customer.Id + " Numaralı Müşteri Güncellendi...");
                customer.TotalShopping = 50;
                customer.TotalPrice = 5000;
                Console.WriteLine("Muşteri Numarası: " + customer.Id);
                Console.WriteLine("Ad: " + customer.Name);
                Console.WriteLine("Soyad: " + customer.Surname);
                Console.WriteLine("Total Alışveriş: " + customer.TotalShopping);
                Console.WriteLine("Total Fiyat: " + customer.TotalPrice);
            }
            else
            {
                Console.WriteLine("Güncellenecek Muşteri Bulunamadı!!!");
            }
        }
        public void Delete(Customer customer, int id)
        {
            if (customer.Id == id)
            {
                Console.WriteLine(id + " Numaralı Müşteri Silindi...");
            }
            else
            {
                Console.WriteLine("Müşteri Bulunamadı");
            }

        }
    }
}
