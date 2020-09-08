using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] field = new int[n];
            for (int i = 0; i < n; i++)
            {
                field[i] = 0;
            }

            int[] bugsPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < bugsPositions.Length; i++)
            {
                int currentIdx = bugsPositions[i];

                if (currentIdx >= 0 && currentIdx < field.Length)
                {
                    field[currentIdx] = 1;
                }
            }


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] options = input.Split();

                int bugIdx = int.Parse(options[0]);
                string direction = options[1];
                int flyLength = int.Parse(options[2]);

                // Validate bugIdx
                if (field[bugIdx] == 0 || bugIdx < 0 || bugIdx > field.Length - 1)
                {
                    continue;
                }

                field[bugIdx] = 0;

                if (direction == "right")
                {
                    int flyDestination = bugIdx + flyLength;

                    if (flyDestination >= field.Length)
                    {
                        continue;
                    }

                    if (field[flyDestination] == 1)
                    {
                        while (field[flyDestination] == 1)
                        {
                            flyDestination += flyLength;
                            if (flyDestination > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (flyDestination >= 0 && flyDestination <= field.Length - 1)
                    {
                        field[flyDestination] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int flyDestination = bugIdx - flyLength;

                    if (flyDestination < 0)
                    {
                        continue;
                    }

                    if (field[flyDestination] == 1)
                    {
                        while (field[flyDestination] == 1)
                        {
                            flyDestination -= flyLength;
                            if (flyDestination > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (flyDestination >= 0 && flyDestination <= field.Length - 1)
                    {
                        field[flyDestination] = 1;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
