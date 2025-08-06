using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(50);
            product.Name = "Laptop";

            Product gsm = new Product(50);
            gsm.Name = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                product.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Stock is low for GSM. Please restock.");
        }
    }
}
