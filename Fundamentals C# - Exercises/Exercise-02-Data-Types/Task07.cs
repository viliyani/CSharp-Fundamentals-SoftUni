using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int tank = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (liters + tank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tank += liters;
                }

            }

            Console.WriteLine(tank);

        }
    }
}