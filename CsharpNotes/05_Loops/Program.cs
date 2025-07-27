using System;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoops();
            //WhileLoops();
            //DoWhileLoops();
            //NestedLoops();
            //DoNestedLoops();
            //forEachLoop();
            if(IsPrimeNumber(29))
            {
                Console.WriteLine("29 is a prime number.");
            }
            else
            {
                Console.WriteLine("29 is not a prime number.");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for(int i = 2; i<number/2; i++)
            {
                if(number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static void ForLoops()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void WhileLoops()
        {
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void DoWhileLoops()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 20);
        }
        private static void NestedLoops()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                }
            }
        }
        private static void DoNestedLoops()
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                    j++;
                } while (j <= 5);
                i++;
            } while (i <= 5);
        }
        private static void forEachLoop()
        {
            string[] students = { "Ali", "Yıldırım", "Emir", "Erol" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
}
