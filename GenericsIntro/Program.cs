using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ahmet");

            foreach (var item in isimler.ArrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
