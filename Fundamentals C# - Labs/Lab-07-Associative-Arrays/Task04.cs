using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] sorted = numbers.OrderByDescending(x => x).ToArray();

            var result = new List<int>() { };

            int br = 0;
            for (int i = 0; i < sorted.Length; i++)
            {
                result.Add(sorted[i]);
                br++;
                if (br >= 3)
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}