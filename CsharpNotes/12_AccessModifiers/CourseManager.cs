using System;
namespace _12_AccessModifiers
{
    internal class CourseManager
    {
       CoursePublic coursePublic = new CoursePublic();
        public void Add()
        {
            coursePublic.Add(); // This will call the Add method in CoursePublic
            Console.WriteLine("CourseManager: Course added successfully.");
        }
    }
}
