using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> arrays = input.Split('|').Reverse().ToList();

            int idx = 0;

            foreach (var item in arrays)
            {
                List<int> temp = item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                Console.Write(String.Join(" ", temp));
                Console.Write(" ");
                idx++;
            }

            Console.WriteLine();
        }
    }
}