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
            string[] players = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            var dict = new Dictionary<string, int>() { };

            for (int i = 0; i < players.Length; i++)
            {
                dict.Add(players[i], 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = String.Empty;
                int points = 0;

                // Get name
                string pattern1 = @"[A-Za-z]";

                var matches1 = Regex.Matches(input, pattern1);

                List<string> letters = new List<string>() { };

                foreach (Match match in matches1)
                {
                    letters.Add(match.Value);
                }

                name = string.Join("", letters);

                // Get points
                string pattern2 = @"[0-9]";

                var matches2 = Regex.Matches(input, pattern2);

                List<int> digits = new List<int>() { };

                foreach (Match match in matches2)
                {
                    points += int.Parse(match.Value);
                }

                // Add to dictionary
                if (dict.ContainsKey(name))
                {
                    dict[name] += points;
                }

                input = Console.ReadLine();
            }

            var result = dict.OrderByDescending(x=>x.Value).ToArray();
            
            Console.WriteLine($"1st place: {result[0].Key}");
            Console.WriteLine($"2nd place: {result[1].Key}");
            Console.WriteLine($"3rd place: {result[2].Key}");
        }
    }
}