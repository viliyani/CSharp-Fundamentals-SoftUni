using System;
using System.Collections.Generic;
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

            double total = 0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                string pattern = @"^\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<qty>[0-9]+)\|[^|$%.0-9]*(?<price>[0-9.]+)\$$";

                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    double current = double.Parse(match.Groups["qty"].Value) * double.Parse(match.Groups["price"].Value);

                    total += current;

                    Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["product"].Value} - {current:f2}");
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"Total income: {total:f2}");

        }
    }
}