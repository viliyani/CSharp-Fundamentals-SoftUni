using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] options = command.Split();

                if (options[0] == "Shoot")
                {
                    Shoot(targets, int.Parse(options[1]), int.Parse(options[2]));
                }
                else if (options[0] == "Add")
                {
                    Add(targets, int.Parse(options[1]), int.Parse(options[2]));
                }
                else if (options[0] == "Strike")
                {
                    Strike(targets, int.Parse(options[1]), int.Parse(options[2]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join("|", targets));
        }

        static void Shoot(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                if (power >= targets[index])
                {
                    targets.RemoveAt(index);
                }
                else
                {
                    targets[index] -= power;
                }
            }
        }

        static void Add(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Strike(List<int> targets, int index, int radius)
        {
            if (index >= 0 && index < targets.Count)
            {
                if (index - radius >= 0 && index + radius < targets.Count)
                {
                    targets.RemoveRange(index - radius, 2 * radius + 1);
                }
                else
                {
                    Console.WriteLine("Strike missed!");
                }
            }
        }
    }
}