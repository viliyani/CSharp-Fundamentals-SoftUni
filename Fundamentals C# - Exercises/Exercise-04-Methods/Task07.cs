using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix(int.Parse(Console.ReadLine()));
        }

        static void Matrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
