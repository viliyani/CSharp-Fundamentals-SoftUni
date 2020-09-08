using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            int[] encrypted = new int[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                string name = names[i];

                int sum = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    char letter = char.Parse(name[j].ToString().ToLower());
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        // vowel
                        sum += name[j] * name.Length;
                    }
                    else
                    {
                        // consonant
                        sum += name[j] / name.Length;
                    }

                }

                encrypted[i] = sum;
            }

            encrypted = encrypted.OrderBy(x => x).ToArray();

            foreach (var item in encrypted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
