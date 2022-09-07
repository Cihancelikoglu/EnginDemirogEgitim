using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adepters;
using InterfaceAbstractDemo.Concrate;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1999, 05, 09),
                FirstName = "Cihan",
                LastName = "Çelikoğlu",
                NationalityId = "64300199406"
            });

            Console.ReadLine();
        }
    }
}
