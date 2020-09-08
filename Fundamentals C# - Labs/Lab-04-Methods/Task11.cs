using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", Calculate(a, b, operation));
        }

        static double Calculate(double a, double b, string operation)
        {
            double result = 0;

            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else if (operation == "/")
            {
                result = a / b;
            }

            return result;
        }
    }
}