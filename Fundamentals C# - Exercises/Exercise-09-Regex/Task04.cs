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
            List<string> attacked = new List<string>() { };
            List<string> destroyed = new List<string>() { };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string patternKey = @"[starSTAR]";
                var matchesKey = Regex.Matches(input, patternKey);

                int num = matchesKey.Count;

                StringBuilder msg = new StringBuilder() { };

                for (int j = 0; j < input.Length; j++)
                {
                    msg.Append((char)(input[j] - num));
                }

                string pattern = @"[^@\-!:>]*?@[^@\-!:>]*?(?<name>[A-Za-z]+)[^@\-!:>]*?:[^@\-!:>]*?[0-9]+[^@\-!:>]![^@\-!:>]*?(?<type>[AD])[^@\-!:>]*?![^@\-!:>]*->[^@\-!:>]*[0-9]+[^@\-!:>]*";
                var match = Regex.Match(msg.ToString(), pattern);

                if (match.Success)
                {
                    if (match.Groups["type"].Value == "A")
                    {
                        attacked.Add(match.Groups["name"].Value);
                    } else
                    {
                        destroyed.Add(match.Groups["name"].Value);
                    }
                }
            }


            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var item in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var item in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

        }
    }
}