using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }

        static int MinNumber(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
