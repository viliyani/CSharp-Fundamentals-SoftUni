using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());

            Result(product, qty);
        }

        static void Result(string product, int qty)
        {
            double unitPrice = 0.0;

            if (product == "coffee")
            {
                unitPrice = 1.50;
            }
            else if (product == "water")
            {
                unitPrice = 1.0;
            }
            else if (product == "coke")
            {
                unitPrice = 1.40;
            }
            else if (product == "snacks")
            {
                unitPrice = 2.0;
            }

            Console.WriteLine($"{unitPrice * qty:f2}");
        }
    }
}