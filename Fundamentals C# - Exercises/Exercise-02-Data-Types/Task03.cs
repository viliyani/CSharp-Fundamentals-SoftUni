using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            if (n % p == 0)
            {
                Console.WriteLine(n / p);
            }
            else
            {
                Console.WriteLine(n / p + 1);
            }
        }
    }
}