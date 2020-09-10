using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Middle(Console.ReadLine());
        }

        static void Middle(string str)
        {
            int n = str.Length;

            if (n % 2 == 0)
            {
                Console.Write(str[n / 2 - 1]);
                Console.Write(str[n / 2]);
            }
            else
            {
                Console.Write(str[n / 2]);
            }

            Console.WriteLine();
        }

    }
}
