using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                List<string> options = command.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (options[0] == "Collect")
                {
                    if (!items.Contains(options[1]))
                    {
                        items.Add(options[1]);
                    }
                }
                else if (options[0] == "Drop")
                {
                    if (items.Contains(options[1]))
                    {
                        items.Remove(options[1]);
                    }
                }
                else if (options[0] == "Combine Items")
                {
                    List<string> oldAndNew = options[1].Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (items.Contains(oldAndNew[0]))
                    {
                        items.Insert(items.IndexOf(oldAndNew[0]) + 1, oldAndNew[1]);
                    }
                }
                else if (options[0] == "Renew")
                {

                    if (items.Contains(options[1]))
                    {
                        items.Remove(options[1]);
                        items.Add(options[1]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", items));
        }
    }
}