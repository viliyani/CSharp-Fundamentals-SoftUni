using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
        	List<string> destinations = new List<string>() {};

            string text = Console.ReadLine();

            string pattern = @"(?<sep>[=\/])(?<name>[A-Z][a-zA-Z]{2,})\k<sep>";

            var matches = Regex.Matches(text, pattern);

            int total = 0;

            foreach (Match match in matches) {
            	string word = match.Groups["name"].Value;

            	total += word.Length;

                destinations.Add(word);
            }


            Console.WriteLine("Destinations: {0}", String.Join(", ", destinations));
            Console.WriteLine($"Travel Points: {total}");
        }
    }
}