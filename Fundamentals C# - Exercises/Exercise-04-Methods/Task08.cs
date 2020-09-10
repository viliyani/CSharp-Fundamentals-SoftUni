using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double result = Factorial(a) / Factorial(b);

            Console.WriteLine($"{result:f2}");
        }

        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            double m = 1;

            for (int i = 1; i <= n; i++)
            {
                m *= i;
            }

            return m;
        }

    }
}
