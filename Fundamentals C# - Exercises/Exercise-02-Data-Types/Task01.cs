using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int result = a + b;
            result /= c;
            result *= d;

            Console.WriteLine(result);
            
        }
    }
}