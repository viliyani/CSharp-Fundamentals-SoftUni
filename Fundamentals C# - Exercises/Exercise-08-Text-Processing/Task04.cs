using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                str.Append((char)(input[i] + 3));
            }

            Console.WriteLine(str.ToString());
        }
    }
}