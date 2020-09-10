using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CharsInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }

        static void CharsInRange(char from, char to)
        {
            char start = (char)Math.Min(from,to);
            char end = (char)Math.Max(from,to);

            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
