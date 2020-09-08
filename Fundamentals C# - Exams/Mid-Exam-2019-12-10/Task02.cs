using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split('|').Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int points = 0;

            while (command != "Game over")
            {
                if (command == "Reverse")
                {
                    for (int i = 0; i < numbers.Length / 2; i++)
                    {
                        int swap = numbers[i];
                        numbers[i] = numbers[numbers.Length - i - 1];
                        numbers[numbers.Length - i - 1] = swap;
                    }
                }
                else
                {
                    string[] options = command.Split('@');
                    if (options[0] == "Shoot Left")
                    {
                        int startIndex = int.Parse(options[1]);
                        int length = int.Parse(options[2]);

                        if (startIndex >= 0 && startIndex < numbers.Length)
                        {
                            int target = startIndex - 1;
                            for (int i = 1; i <= length; i++)
                            {
                                if (target <= 0)
                                {
                                    target = numbers.Length - 1;
                                }
                                else
                                {
                                    target--;
                                }
                            }

                            if (numbers[target] < 5)
                            {
                                points += numbers[target];
                                numbers[target] = 0;
                            }
                            else
                            {
                                points += 5;
                                numbers[target] -= 5;
                            }
                        }
                    }
                    else if (options[0] == "Shoot Right")
                    {
                        int startIndex = int.Parse(options[1]);
                        int length = int.Parse(options[2]);

                        if (startIndex >= 0 && startIndex < numbers.Length)
                        {
                            int target = startIndex + 1;

                            for (int i = 1; i <= length; i++)
                            {
                                if (target >= numbers.Length - 1)
                                {
                                    target = 0;
                                }
                                else
                                {
                                    target++;
                                }
                            }

                            if (numbers[target] < 5)
                            {
                                points += numbers[target];
                                numbers[target] = 0;
                            }
                            else
                            {
                                points += 5;
                                numbers[target] -= 5;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" - ", numbers));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}