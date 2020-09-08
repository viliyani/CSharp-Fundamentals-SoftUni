using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bans = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bans.Length; i++)
            {
                text = text.Replace(bans[i], new string('*', bans[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}