using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 15;

            if (number == 10)
            {
                Console.WriteLine("Number is exactly 10");
            }
            else if (number < 10)
            {
                Console.WriteLine("Number is less than 10");
            }
            else
            {
                Console.WriteLine("Number is greater than 10");
            }

            string message = (number % 2 == 0) ? "Even number" : "Odd number";
            Console.WriteLine(message);

            if (number > 0)
            {
                if (number < 100)
                {
                    Console.WriteLine("Number is positive and less than 100");
                }
            }

            if (number > 0 && number < 20)
            {
                Console.WriteLine("Number is between 1 and 19");
            }

            if (number < 0 || number > 100)
            {
                Console.WriteLine("Number is outside the range 0-100");
            }

            bool isActive = false;

            if (!isActive)
            {
                Console.WriteLine("Not active");
            }

            switch (number)
            {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 15:
                    Console.WriteLine("Number is 15");
                    break;
                default:
                    Console.WriteLine("Number is something else");
                    break;
            }
        }
    }
}
