using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int lastIdx = Math.Max(numbers1.Count, numbers2.Count);

            for (int i = 0; i < lastIdx; i++)
            {
                if (i >= numbers1.Count)
                {
                    result.Add(numbers2[i]);
                }
                else if (i >= numbers2.Count)
                {
                    result.Add(numbers1[i]);
                }
                else
                {
                    result.Add(numbers1[i]);
                    result.Add(numbers2[i]);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}