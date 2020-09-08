using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dict = new Dictionary<string, int>() { };

            while (input != "stop")
            {
                int qty = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(input))
                {
                    dict[input] += qty;
                }
                else
                {
                    dict.Add(input, qty);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}