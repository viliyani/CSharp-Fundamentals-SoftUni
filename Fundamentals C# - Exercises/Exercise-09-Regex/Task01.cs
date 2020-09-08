using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>() { };
            double total = 0.0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                string pattern = @"\>\>(?<name>[A-Za-z]+)\<\<(?<price>[0-9\.]+)!(?<qty>[0-9]+)";

                var matches = Regex.Matches(input, pattern);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        items.Add(match.Groups["name"].Value);
                        total += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["qty"].Value);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (items.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, items));
            }
            Console.WriteLine("Total money spend: {0:f2}", total);
        }
    }
}