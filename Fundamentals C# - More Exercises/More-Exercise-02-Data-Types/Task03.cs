using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Abs(double.Parse(Console.ReadLine()));
            double b = Math.Abs(double.Parse(Console.ReadLine()));

            double eps = 0.000001;

            if (Math.Abs(a-b) <= eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}