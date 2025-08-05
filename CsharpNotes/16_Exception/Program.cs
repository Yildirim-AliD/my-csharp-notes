using System;
using System.Collections.Generic;


namespace _16_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Method
            HandleException(() => { Find(); });
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
