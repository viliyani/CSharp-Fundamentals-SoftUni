using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(num));
                    break;
                }
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}