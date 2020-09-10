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

            CheckSign(a, b, c);
        }

        static void CheckSign(int num1, int num2, int num3)
        {
            int negatives = 0;

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }

            if (num1 < 0)
            {
                negatives++;
            }

            if (num2 < 0)
            {
                negatives++;
            }

            if (num3 < 0)
            {
                negatives++;
            }

            if (negatives % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
