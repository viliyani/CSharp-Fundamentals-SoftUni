using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }

        static int Fib(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }

            return Fib(x - 1) + Fib(x-2);
        }
    }
}
