using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] options = command.Split();

                if (options[0] == "Switch")
                {
                    Switch(numbers, int.Parse(options[1]));
                }
                else if (options[0] == "Change")
                {
                    Change(numbers, int.Parse(options[1]), int.Parse(options[2]));
                }
                else if (options[0] == "Sum" && options[1] == "Negative")
                {
                    Console.WriteLine(SumNegative(numbers));
                }
                else if (options[0] == "Sum" && options[1] == "Positive")
                {
                    Console.WriteLine(SumPositive(numbers));
                }
                else if (options[0] == "Sum" && options[1] == "All")
                {
                    Console.WriteLine(SumAll(numbers));
                }

                command = Console.ReadLine();
            }

            PrintPositive(numbers);
        }

        static void Switch(int[] numbers, int index)
        {
            if (index >= 0 && index < numbers.Length)
            {
                numbers[index] *= -1;
            }
        }

        static void Change(int[] numbers, int index, int value)
        {
            if (index >= 0 && index < numbers.Length)
            {
                numbers[index] *= value;
            }
        }

        static int SumNegative(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        static int SumPositive(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        static int SumAll(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static void PrintPositive(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}