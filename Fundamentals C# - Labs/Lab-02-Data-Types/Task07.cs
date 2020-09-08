using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string between = Console.ReadLine();

            Console.WriteLine($"{name1}{between}{name2}");
        }
    }
}