using System;

namespace _09_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[]
            {
               new Customer
               {
                     Id = 1,
                     FirstName = "Ali",
                     LastName = "Yıldırım",
                     City = "İzmir"
               },new Student
               {
                        Id = 2,
                        FirstName = "Yıldırım",
                        LastName = "Yılmaz",
                        Department = "Computer Science"
               },new Person
               {
                   FirstName = "Mehmet",
               }

            };

            foreach(var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {

    }

    interface IPerson3
    {

    }

    class Customer : Person, IPerson3
    {
        public string City { get; set; }
    }
    
    class Student : Person
    {
        public string Department { get; set; }
    }
}
