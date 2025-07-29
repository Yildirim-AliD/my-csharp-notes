using System;

namespace _12_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int id { get; set; } // Protected access modifier allows access within the same class and derived
        private int age; // Private access modifier restricts access to the same class only
        public string Name { get; set; } // Public access modifier allows access from anywhere
        public void Save()
        {
            id = 1; // Accessible within the same class
        }

    }

    class Student : Customer
    {

        public void Save3()
        {
            // customer.age = 20; // Not accessible because age is private
            id = 3; // Accessible because id is protected
            Name = "Ali"; // Accessible because Name is public
        }
    }
    internal class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {
            public string Detail { get; set; }
        }

    }

    public class CoursePublic
    {
        public void Add()
        {
            Console.WriteLine("Course added.");
        }
    }

}
