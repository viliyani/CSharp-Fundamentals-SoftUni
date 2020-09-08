using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>() { };

            string input = Console.ReadLine();

            while (input != "end")
            {
                strings.Add(input);

                input = Console.ReadLine();
            }

            for (int i = 0; i < strings.Count; i++)
            {
                string reversed = "";
                for (int j = strings[i].Length - 1; j >= 0; j--)
                {
                    reversed += strings[i][j];
                }
                Console.WriteLine("{0} = {1}", strings[i], reversed);
            }
        }
    }
}