using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            string str = $"{a}{b}{c}";
            Console.WriteLine(str);
        }
    }
}