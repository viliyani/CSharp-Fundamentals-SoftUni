using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            double total = 0;

            foreach (var item in numbers)
            {
                total += item;
            }

            double average = total / numbers.Count;

            numbers.Sort();
            int br = 0;

            List<double> result = new List<double>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > average && numbers[i] != average)
                {
                    result.Add(numbers[i]);
                    br++;
                }

                if (br >= 5)
                {
                    break;
                }
            }

            if (result.Count > 0)
            {
                Console.WriteLine(String.Join(" ", result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}