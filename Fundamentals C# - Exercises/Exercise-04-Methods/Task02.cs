using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelsCount(Console.ReadLine()));
        }

        static int VowelsCount(string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char letter = char.Parse(str[i].ToString().ToLower());
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'u' || letter == 'o')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
