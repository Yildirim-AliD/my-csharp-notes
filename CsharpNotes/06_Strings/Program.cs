using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Ali yıldırım";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.EndsWith("Ali");
            bool result4 = sentence.StartsWith("My");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf("Name");
            var result7 = sentence.LastIndexOf("i");
            var result8 = sentence.Insert(0, "Hello,");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2);
            Console.WriteLine(result);
        }

        private static void Intro()
        {
            string city = "İzmir";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + " " + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
