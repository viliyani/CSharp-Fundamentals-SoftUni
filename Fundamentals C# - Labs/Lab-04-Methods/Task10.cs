using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(number)));
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int temp = number;

            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                temp = temp / 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int temp = number;

            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }

                temp = temp / 10;
            }

            return sum;
        }
    }
}