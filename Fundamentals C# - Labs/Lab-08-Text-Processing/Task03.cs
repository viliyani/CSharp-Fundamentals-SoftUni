using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine().ToLower();
            string str = Console.ReadLine();

            int idx = str.IndexOf(remove);

            while (idx != -1)
            {
                str = str.Substring(0, idx) + str.Substring(idx + remove.Length, str.Length - (idx + remove.Length));

                idx = str.IndexOf(remove);
            }

            Console.WriteLine(str);
        }
    }
}