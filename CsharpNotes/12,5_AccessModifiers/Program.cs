using _12_AccessModifiers;
using System;
namespace _12_5_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CoursePublic coursePublic = new CoursePublic();
           coursePublic.Add(); // This will call the Add method in CoursePublic
            Console.WriteLine("Program: Course added successfully.");
            
        }
    }
}
