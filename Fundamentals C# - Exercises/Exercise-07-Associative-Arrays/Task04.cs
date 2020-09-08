using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Pair
    {
        public double price;
        public int qty;
    }
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, Pair> products = new Dictionary<string, Pair>() { };

            while (input != "buy")
            {
                string[] options = input.Split();
                string product = options[0];
                double price = double.Parse(options[1]);
                int qty = int.Parse(options[2]);

                if (products.ContainsKey(product))
                {
                    products[product].price = price;
                    products[product].qty += qty;
                }
                else
                {
                    var temp = new Pair() { };
                    temp.price = price;
                    temp.qty = qty;

                    products.Add(product, temp);
                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.price * item.Value.qty:f2}");
            }
        }
    }
}