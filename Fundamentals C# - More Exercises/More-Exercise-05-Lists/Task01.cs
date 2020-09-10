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
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder() { };
            StringBuilder result = new StringBuilder() { };

            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(str[i]);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                int sum = 0;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                int idx = sum;

                if (idx >= sb.Length)
                {
                    idx = sum % sb.Length;
                }

                result.Append(sb[idx]);
                sb.Remove(idx, 1);
            }

            Console.WriteLine(result.ToString());

        }
    }
}
