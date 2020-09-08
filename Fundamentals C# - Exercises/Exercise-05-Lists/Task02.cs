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

            while (command != "end")
            {
                string[] options = command.Split();

                if (options[0] == "Delete")
                {
                    int element = int.Parse(options[1]);
                    list.RemoveAll(current => current == int.Parse(options[1]));
                }
                else if (options[0] == "Insert")
                {
                    int index = int.Parse(options[2]);
                    list.Insert(index, int.Parse(options[1]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}