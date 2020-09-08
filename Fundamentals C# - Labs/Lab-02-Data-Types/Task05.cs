using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int temp = i;
                int sum = 0;

                while (temp > 0)
                {
                    sum += temp % 10;
                    temp = temp / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");

                }
            }

        }
    }
}