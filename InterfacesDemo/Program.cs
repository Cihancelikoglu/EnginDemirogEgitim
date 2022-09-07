using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3];
            new Manager();
            new Worker();
            new Robot();

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[3];
            new Manager();
            new Worker();

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
}
