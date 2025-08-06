using System;
using System.Collections.Generic;
using System.Threading;


namespace _16_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();

            ////Method
            //ActionDemo();

            Func<int, int, int> toplama = Toplama;
            Console.WriteLine(toplama(5, 10));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1000); // Ensures that the random number is different each time

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
            

        }

        static int Toplama(int a, int b)
        {
            return a + b;
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action value)
        {
            try
            {
                value.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ali", "Veli", "Ayşe" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException ("Record not found");
            }
            else
            {
                Console.WriteLine("Record found.");

            }
        }

        private static void ExceptionIntro()
        {
            string[] students = new string[3] { "Ali", "Veli", "Ayşe" };
            try
            {
                // Attempt to access an index that is out of bounds
                Console.WriteLine(students[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Handle the specific exception for index out of range
                Console.WriteLine("Index out of range: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle the exception and display a message
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            finally
            {
                // This block will always execute, regardless of whether an exception occurred or not
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
