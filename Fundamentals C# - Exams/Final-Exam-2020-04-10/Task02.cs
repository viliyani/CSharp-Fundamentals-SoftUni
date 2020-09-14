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
        	List<string> pairs = new List<string>() {};
        	int counter = 0;

            string text = Console.ReadLine();

            string pattern = @"(?<sep>[#@])(?<word1>[a-zA-Z]{3,})\k<sep>{2}(?<word2>[a-zA-Z]{3,})\k<sep>";

            var matches = Regex.Matches(text, pattern);

            counter = matches.Count;

            foreach (Match match in matches) {
            	string word1 = match.Groups["word1"].Value;
            	string word2 = match.Groups["word2"].Value;

            	if (word1.Length == word2.Length) {

            		bool isPair = true;

            		for(int i = 0; i < word1.Length; i++) {
            			if (word1[i] != word2[word2.Length - 1 - i]) {
            				isPair = false;
            				break;
            			}
            		}

            		if (isPair) {
            			pairs.Add(word1+" <=> "+word2);
            		}
            	}
            }

            if (counter == 0) {
            	Console.WriteLine($"No word pairs found!");
            } else {
            	Console.WriteLine($"{counter} word pairs found!");
            }

            if (pairs.Count == 0) {
            	Console.WriteLine("No mirror words!");
            } else {
            	Console.WriteLine("The mirror words are:");
            	Console.WriteLine(String.Join(", ", pairs));
            }
        }
    }
}