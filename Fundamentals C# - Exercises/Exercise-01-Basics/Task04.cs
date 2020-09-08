using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = from; i <= to; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}