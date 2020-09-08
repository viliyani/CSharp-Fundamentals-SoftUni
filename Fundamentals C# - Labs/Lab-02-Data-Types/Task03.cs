using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            decimal sum = 0M;

            for (int i = 0; i < n; i++)
            {
                decimal x = decimal.Parse(Console.ReadLine());

                sum += x;
            }

            Console.WriteLine(sum);
        }
    }
}