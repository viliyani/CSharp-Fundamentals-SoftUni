using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string action = Console.ReadLine();

            while (action != "end")
            {
                string[] input = action.Split();

                if (input[0] == "Add")
                {
                    numbers.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    numbers.Remove(int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    if (int.Parse(input[2]) <= numbers.Count)
                    {
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    }
                }

                action = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}