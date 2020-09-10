using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "course start")
                {
                    break;
                }

                string[] options = input.Split(new string[] { ":" }, StringSplitOptions.None);

                if (options[0] == "Add")
                {
                    string title = options[1];

                    if (!strings.Contains(title))
                    {
                        strings.Add(title);
                    }
                }
                else if (options[0] == "Insert")
                {
                    string title = options[1];
                    int idx = int.Parse(options[2]);

                    if (!strings.Contains(title))
                    {
                        strings.Insert(idx, title);
                    }
                }
                else if (options[0] == "Remove")
                {
                    string title = options[1];

                    if (strings.Contains(title))
                    {
                        strings.Remove(title);
                        if (strings.Contains(title + "-Exercise"))
                        {
                            strings.Remove(title + "-Exercise");
                        }
                    }
                }
                else if (options[0] == "Swap")
                {
                    string title1 = options[1];
                    string title2 = options[2];

                    if (strings.Contains(title1) && strings.Contains(title2))
                    {
                        int idx1 = strings.IndexOf(title1);
                        int idx2 = strings.IndexOf(title2);

                        strings[idx2] = title1;
                        strings[idx1] = title2;

                        string ex1 = title1 + "-Exercise";
                        string ex2 = title2 + "-Exercise";

                        if (strings.Contains(ex1))
                        {
                            strings.Remove(ex1);
                            strings.Insert(idx2 + 1, ex1);
                        }

                        if (strings.Contains(ex2))
                        {
                            strings.Remove(ex2);
                            strings.Insert(idx1 + 1, ex2);
                        }
                    }
                }
                else if (options[0] == "Exercise")
                {
                    string title = options[1];

                    if (strings.Contains(title))
                    {
                        if (!strings.Contains(title + "-Exercise"))
                        {
                            strings.Insert(strings.IndexOf(title) + 1, title + "-Exercise");
                        }
                    }
                    else
                    {
                        strings.Add(title);
                        strings.Add(title + "-Exercise");
                    }
                }

            }

            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{strings[i]}");
            }

        }
    }
}
