using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int from = int.Parse(Console.ReadLine());

            if (from > 9)
            {
                Console.WriteLine($"{num} X {from} = {num * from}");
            }
            else
            {
                for (int i = from; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
        }
    }
}