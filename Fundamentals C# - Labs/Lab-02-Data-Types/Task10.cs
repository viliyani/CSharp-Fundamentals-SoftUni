using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());

            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}