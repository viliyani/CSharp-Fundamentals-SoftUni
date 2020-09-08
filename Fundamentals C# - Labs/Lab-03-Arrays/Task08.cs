using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int k = 0; k < numbers.Length - 1; k++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
            }

            Console.WriteLine(numbers[0]);
        }
    }
}