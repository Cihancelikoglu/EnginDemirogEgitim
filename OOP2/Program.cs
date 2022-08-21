using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri customer1 = new GercekMusteri();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Cihan";
            customer1.Surname = "Çelikoğlu";
            customer1.TcNo = "000000";

            TuzelMusteri customer2 = new TuzelMusteri();
            customer2.Id = 2;
            customer2.CustomerNumber = "654123";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID - 

            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
