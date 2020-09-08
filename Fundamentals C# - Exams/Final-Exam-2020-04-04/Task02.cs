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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"@[#]+[A-Z][a-zA-Z0-9]{4,}[A-Z]@[#]+";

                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string patternDigits = @"[0-9]";
                    var matches = Regex.Matches(input, patternDigits);

                    if (matches.Count > 0)
                    {
                        Console.WriteLine("Product group: {0}", String.Join("", from Match mat in matches select mat.Value));
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}