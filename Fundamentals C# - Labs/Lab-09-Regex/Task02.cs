using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            var matched = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}