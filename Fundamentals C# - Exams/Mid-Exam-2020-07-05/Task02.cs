using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] options = command.Split();

                if (options[0] == "swap")
                {
                    int idx1 = int.Parse(options[1]);
                    int idx2 = int.Parse(options[2]);

                    int swap = numbers[idx1];
                    numbers[idx1] = numbers[idx2];
                    numbers[idx2] = swap;
                }
                else if (options[0] == "multiply")
                {
                    int idx1 = int.Parse(options[1]);
                    int idx2 = int.Parse(options[2]);

                    numbers[idx1] *= numbers[idx2];
                }
                else if (options[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}