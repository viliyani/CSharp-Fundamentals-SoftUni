using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> merged = new List<int>() { };

            int from = 0;
            int to = 0;

            if (numbers1.Count > numbers2.Count)
            {
                from = Math.Min(numbers1[numbers1.Count - 1], numbers1[numbers1.Count - 2]);
                to = Math.Max(numbers1[numbers1.Count - 1], numbers1[numbers1.Count - 2]);

                numbers1.RemoveAt(numbers1.Count-1);
                numbers1.RemoveAt(numbers1.Count-1);
            }
            else
            {
                from = Math.Min(numbers2[0], numbers2[1]);
                to = Math.Max(numbers2[0], numbers2[1]);

                numbers2.RemoveAt(0);
                numbers2.RemoveAt(1);
            }

            for (int i = 0; i < numbers1.Count; i++)
            {
                merged.Add(numbers1[i]);
                merged.Add(numbers2[numbers1.Count - i - 1]);
            }

            Console.WriteLine(String.Join(" ", merged.Where(x => x > from && x < to).OrderBy(x => x).ToList()));
        }
    }
}
