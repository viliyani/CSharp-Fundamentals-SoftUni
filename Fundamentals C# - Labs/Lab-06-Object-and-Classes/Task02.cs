using System;
using System.Globalization;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rand = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int idx = rand.Next(0, words.Length);
                string swap = words[i];
                words[i] = words[idx];
                words[idx] = swap;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
