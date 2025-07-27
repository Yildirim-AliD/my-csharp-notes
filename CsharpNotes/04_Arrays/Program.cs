using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];
            students[0] = "Ali";
            students[1] = "Yıldırım";
            students[2] = "Emir";
            students[3] = "Erol";

            string[] students2 = new [] { "Ali", "Yıldırım", "Emir", "Erol" };
            string[] students3 = { "Ali", "Yıldırım", "Emir", "Erol" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[7,3]
            {
                { "Adana", "Mersin", "Hatay" },
                { "İstanbul", "Kocaeli", "Sakarya" },
                { "Ankara", "Konya", "Eskişehir" },
                { "Bursa", "Balıkesir", "Çanakkale" },
                { "Trabzon", "Rize", "Artvin" },
                { "Gaziantep", "Şanlıurfa", "Diyarbakır" },
                { "İzmir", "Muğla", "Aydın"}
            };
            Console.WriteLine("*****************");
            for (int i = 0; i  <= regions.GetUpperBound(0);i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*****************");
            }

        }
    }
}
