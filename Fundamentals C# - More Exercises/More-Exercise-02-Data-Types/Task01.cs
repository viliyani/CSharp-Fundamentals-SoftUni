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

                double d = 0;
                int b = 0;

                if (input.ToLower() == "true" || input.ToLower() == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (int.TryParse(input, out b))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out d))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (input.Length == 1)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

            }
        }
    }
}