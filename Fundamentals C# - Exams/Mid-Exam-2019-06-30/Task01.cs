using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            decimal stepsDistance = decimal.Parse(Console.ReadLine());
            decimal targetDistance = decimal.Parse(Console.ReadLine());

            decimal total = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    total += stepsDistance / 100 * 0.7m;
                }
                else
                {
                    total += stepsDistance / 100m;
                }
            }

            decimal percentage = 100 * total / targetDistance;

            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}