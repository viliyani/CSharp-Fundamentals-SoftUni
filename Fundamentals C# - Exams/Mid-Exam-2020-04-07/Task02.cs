using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int idx = int.Parse(command);

                if (idx >= 0 && idx < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (i != idx && targets[i] != -1)
                        {
                            if (targets[i] > targets[idx])
                            {
                                targets[i] -= targets[idx];
                            }
                            else
                            {
                                targets[i] += targets[idx];
                            }
                        }
                    }

                    targets[idx] = -1;
                    count++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {String.Join(" ", targets)}");
        }
    }
}