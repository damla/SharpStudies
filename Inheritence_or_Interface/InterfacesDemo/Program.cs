using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] { new Worker(), new Manager(), new Robot() };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] { new Worker(), new Manager() };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
}

/*
 * Demo information:
 * We have a company made of workers, robots and managers.
 * Create interface structure for this company.
 */