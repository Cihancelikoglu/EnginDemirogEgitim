using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Tülin", "Cihan", "Ahmet", "Engin", "Kerem" };
            Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>() { "Tülin", "Cihan", "Ahmet", "Engin", "Kerem" };
            Console.WriteLine(isimler2[1]);
        }
    }
}
