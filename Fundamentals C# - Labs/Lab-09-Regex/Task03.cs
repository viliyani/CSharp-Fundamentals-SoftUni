using System;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>[0-9]{2})(?<separ>.)(?<month>[A-Za-z]{3})\k<separ>(?<year>\d{4})";

            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: { match.Groups["year"].Value}");
            }

            Console.WriteLine();
        }
    }
}