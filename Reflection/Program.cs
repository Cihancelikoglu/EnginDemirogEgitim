using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Cıkar());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var type = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,2,3);
            //Console.WriteLine(dortIslem.Topla(2, 3));
            //Console.WriteLine(dortIslem.Cıkar());

            var instance = Activator.CreateInstance(type, 2, 3);
            Console.WriteLine(instance.GetType().GetMethod("Cıkar").Invoke(instance, null));

            var methodlar = type.GetMethods();

            foreach (var info in methodlar)
            {
                Console.WriteLine("Method Adı: {0}", info.Name);
                foreach (var paramater in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", paramater.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }

        }
    }

    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Cıkar()
        {
            return _sayi1 - _sayi2;
        }

        [MethodName("Carpma")]
        public int Bol()
        {
            return _sayi1 / _sayi2;
        }

        public class MethodNameAttribute:Attribute
        {
            public MethodNameAttribute(string name)
            {

            }
        }
    }
}
