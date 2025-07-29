using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var item in workers)
            {
                item.Work();
            }

            IEat[] eaters = new IEat[]
            {
                new Manager(),
                new Worker()
            };
            foreach (var item in eaters)
            {
                item.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }


    class Manager : IWorker, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Manager is working.");
        }
        public void Eat()
        {
            Console.WriteLine("Manager is eating.");
        }
        public void GetSalary()
        {
            Console.WriteLine("Manager is getting salary.");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }
        public void Eat()
        {
            Console.WriteLine("Worker is eating.");
        }
        public void GetSalary()
        {
            Console.WriteLine("Worker is getting salary.");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
