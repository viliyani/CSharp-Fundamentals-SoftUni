using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                wagons[i] = k;
                sum += k;
            }

            Console.WriteLine(String.Join(" ", wagons));
            Console.WriteLine(sum);
        }
    }
}