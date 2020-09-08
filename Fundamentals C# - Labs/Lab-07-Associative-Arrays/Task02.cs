using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var dict = new Dictionary<string, int>() { };

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();

                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict[word] = 1;
                }
            }

            List<string> result = new List<string>() { };
            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}