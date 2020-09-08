using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split(new[] { '|' }).ToArray();

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] options = rooms[i].Split();

                int amount = int.Parse(options[1]);

                if (options[0] == "potion")
                {
                    if (health + amount > 100)
                    {
                        amount = 100 - health;
                    }

                    health += amount;

                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (options[0] == "chest")
                {
                    Console.WriteLine($"You found {amount} bitcoins.");
                    bitcoins += amount;
                }
                else
                {
                    health -= amount;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {options[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {options[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}