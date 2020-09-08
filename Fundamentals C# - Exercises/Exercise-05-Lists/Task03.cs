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

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                if (options.Length == 3)
                {
                    // is going
                    string name = options[0];
                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        list.Add(name);
                    }
                }
                else if (options.Length == 4)
                {
                    // is not going
                    string name = options[0];
                    if (list.Contains(name))
                    {
                        list.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}