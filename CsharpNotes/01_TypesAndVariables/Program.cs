using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main()
        {
            // Console.WriteLine("Hello World");
            double number5 = 10.5;
            //decimal number6 = 10.4m;//10.4M
            char character = 'a';
            int number1 = 10;
            long number2 = 2147483649;
            short number3 = 32767;
            byte number4 = 255;
            //bool is_active = true;
            var number7 = 10;
            var character2 = 'b';
            Console.WriteLine(number1);
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}",number3);
            Console.WriteLine("Number4 is {0}",number4);
            Console.WriteLine("Number5 is {0}",number5);
            Console.WriteLine("Number7 is {0}",number7);
            Console.WriteLine("Character is {0}",character);
            Console.WriteLine("Character is {0}",character);
            Console.WriteLine("Character2 is {0}",(int)character2);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);


        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}