using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var digits = new List<int>() { };
            var chars = new List<char>() { };
            var other = new List<char>() { };

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Add(int.Parse(input[i].ToString()));
                }
                else if (char.IsLetter(input[i]))
                {
                    chars.Add(input[i]);
                } else
                {
                    other.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", chars));
            Console.WriteLine(string.Join("", other));
        }
    }
}