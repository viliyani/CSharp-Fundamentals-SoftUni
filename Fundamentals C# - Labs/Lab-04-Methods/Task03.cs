using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            switch (action)
            {
                case "add":
                    Add(num1, num2);
                    break;
                case "substract":
                    Substract(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;
                default:
                    break;
            }
        }

        static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1 + num2}");
        }

        static void Substract(double num1, double num2)
        {
            Console.WriteLine($"{num1 - num2}");
        }

        static void Multiply(double num1, double num2)
        {
            Console.WriteLine($"{num1 * num2}");
        }

        static void Divide(double num1, double num2)
        {
            Console.WriteLine($"{num1 / num2}");
        }

    }
}