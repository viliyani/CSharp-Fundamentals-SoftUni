using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int diffIdx = -1;

            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] == numbers2[i])
                {
                    sum += numbers1[i];
                }
                else
                {
                    diffIdx = i;
                    break;
                }
            }

            if (diffIdx == -1)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIdx} index");
            }
        }
    }
}