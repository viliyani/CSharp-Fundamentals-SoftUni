using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> counts = new SortedDictionary<int, int>() { };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (counts.ContainsKey(numbers[i]))
                {
                    counts[numbers[i]] += 1;
                }
                else
                {
                    counts.Add(numbers[i], 1);
                }
            }

            foreach (var pair in counts)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}