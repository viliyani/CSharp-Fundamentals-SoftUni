using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (IsPalindrom(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool IsPalindrom(string num)
        {
            bool isPalindrome = true;

            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

    }
}
