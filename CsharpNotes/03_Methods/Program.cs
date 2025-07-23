using System;
using System.Linq;

namespace _03_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();

            Add(5, 10); // 15

            int result = Add(1, 2, 3);
            Console.WriteLine("Add(1,2,3) = " + result);

            Add(1, 2, 3);        
            Add(1, 2, 3, 4);     
            Add(1, 2, 3);        

            int number = 20;
            int number2 = 100;
            int number3; 

            int result2 = AddWithRefAndOut(number, ref number2, out number3);
            Console.WriteLine("AddWithRefAndOut result: " + result2);
            Console.WriteLine("number: " + number);     
            Console.WriteLine("number2: " + number2);  
            Console.WriteLine("number3: " + number3);   

            int total = AddParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Sum using params: " + total);
        }

        static void Add()
        {
            Console.WriteLine("Add method called");
        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Add(int, int) = " + result);
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Add(int a, int b, int c, int d = 5)
        {
            int result = a + b + c + d;
            Console.WriteLine("Add(int, int, int, int=5) = " + result);
        }

        static int AddWithRefAndOut(int a, ref int b, out int c)
        {
            a = 30;    
            b = 40;    
            c = 50;    
            return a + b + c;
        }

        static int AddParams(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
