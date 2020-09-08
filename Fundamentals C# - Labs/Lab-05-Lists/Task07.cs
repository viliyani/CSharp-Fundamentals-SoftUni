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
            bool hasChanges = false;

            while (action != "end")
            {
                string[] input = action.Split();


                if (input[0] == "Add")
                {
                    numbers.Add(int.Parse(input[1]));
                    hasChanges = true;
                }
                else if (input[0] == "Remove")
                {
                    numbers.Remove(int.Parse(input[1]));
                    hasChanges = true;
                }
                else if (input[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(input[1]));
                    hasChanges = true;
                }
                else if (input[0] == "Insert")
                {
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    hasChanges = true;
                }
                else if (input[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(input[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (input[0] == "PrintEven")
                {
                    Console.WriteLine(String.Join(" ", numbers.FindAll(c => c % 2 == 0)));
                }
                else if (input[0] == "PrintOdd")
                {
                    Console.WriteLine(String.Join(" ", numbers.FindAll(c => c % 2 != 0)));
                }
                else if (input[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (input[0] == "Filter")
                {
                    int number = int.Parse(input[2]);

                    switch (input[1])
                    {
                        case "<":
                            Console.WriteLine(String.Join(" ", numbers.FindAll(c => c < number)));
                            break;
                        case ">":
                            Console.WriteLine(String.Join(" ", numbers.FindAll(c => c > number)));
                            break;
                        case "<=":
                            Console.WriteLine(String.Join(" ", numbers.FindAll(c => c <= number)));
                            break;
                        case ">=":
                            Console.WriteLine(String.Join(" ", numbers.FindAll(c => c >= number)));
                            break;
                    }
                }

                action = Console.ReadLine();
            }

            if (hasChanges == true)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}