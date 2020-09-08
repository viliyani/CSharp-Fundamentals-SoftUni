using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)(?<user>[A-Za-z0-9]+[.-]*\w*)*@(?<host>[a-zA-Z]+?([.-][a-zA-Z]*)*\.[a-zA-Z]{2,})";

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine("{0}", match.Value);
            }

        }
    }
}