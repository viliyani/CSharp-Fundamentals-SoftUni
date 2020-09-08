using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] options = command.Split();

                if (options[0] == "Add")
                {
                    list.Add(int.Parse(options[1]));
                }
                else if (options[0] == "Insert")
                {
                    int number = int.Parse(options[1]);
                    int index = int.Parse(options[2]);
                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (options[0] == "Remove")
                {
                    int index = int.Parse(options[1]);
                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (options[0] == "Shift" && options[1] == "left")
                {
                    int count = int.Parse(options[2]);

                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (options[0] == "Shift" && options[1] == "right")
                {
                    int count = int.Parse(options[2]);

                    for (int i = list.Count-1; i >= list.Count - count; i--)
                    {
                        list.Insert(0, list[list.Count - 1]);
                        list.RemoveAt(list.Count - 1);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}