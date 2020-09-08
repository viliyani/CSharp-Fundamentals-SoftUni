using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int passengersLimit = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] options = input.Split();

                if (options[0] == "Add")
                {
                    wagons.Add(int.Parse(options[1]));
                }
                else
                {
                    AddPassengersToWagon(wagons, passengersLimit, int.Parse(input));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", wagons));
        }

        static void AddPassengersToWagon(List<int> wagons, int passengersLimit, int passengersToAdd)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passengersToAdd <= passengersLimit)
                {
                    wagons[i] += passengersToAdd;
                    break;
                }
            }
        }
    }
}