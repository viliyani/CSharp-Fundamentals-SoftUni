using System;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}