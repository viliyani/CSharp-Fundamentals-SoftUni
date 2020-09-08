using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintNumbersFrom1(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintNumbersFrom1(i);
            }
        }

    }
}