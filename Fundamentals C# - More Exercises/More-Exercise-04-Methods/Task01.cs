using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type=="int")
            {
                Console.WriteLine(int.Parse(Console.ReadLine())*2);
            }
            else if (type=="real")
            {
                double num = double.Parse(Console.ReadLine());
                num *= 1.5;
                Console.WriteLine($"{num:f2}");
            }
            else if (type=="string")
            {
                string input = Console.ReadLine();
                Console.WriteLine($"${input}$");
            }
        }
    }
}
