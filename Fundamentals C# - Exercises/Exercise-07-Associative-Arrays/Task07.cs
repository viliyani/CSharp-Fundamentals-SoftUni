using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<double>>() { };

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double mark = double.Parse(Console.ReadLine());

                if (dict.ContainsKey(name))
                {
                    dict[name].Add(mark);
                }
                else
                {
                    dict.Add(name, new List<double>() { mark });
                }
            }

            var avg = new Dictionary<string, double>() { };

            foreach (var item in dict)
            {
                avg.Add(item.Key, (item.Value.Sum() / item.Value.Count));
            }

            foreach (var item in avg.OrderByDescending(x => x.Value).Where(x => x.Value >= 4.50))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}