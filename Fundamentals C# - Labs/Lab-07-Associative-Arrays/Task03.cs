using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<string>>() { };

            for (int i = 0; i < n; i++)
            {
                string word1 = Console.ReadLine();
                string word2 = Console.ReadLine();

                if (dict.ContainsKey(word1))
                {
                    dict[word1].Add(word2);
                }
                else
                {
                    dict.Add(word1, new List<string>() { word2 });
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("{0} - {1}", pair.Key, String.Join(", ", dict[pair.Key]));
            }
        }
    }
}