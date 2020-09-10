using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsDivisibleByEight(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasOddDigit(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 != 0)
                {
                    return true;
                }
                num /= 10;
            }

            return false;
        }

        static bool IsDivisibleByEight(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
