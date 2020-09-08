using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int wonBattles = 0;
            bool stopped = false;

            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy - distance < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }
                else 
                {
                    energy -= distance;
                    wonBattles++;
                }

                if (wonBattles % 3 == 0)
                {
                    energy += wonBattles;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}