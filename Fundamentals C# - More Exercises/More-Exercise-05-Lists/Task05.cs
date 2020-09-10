using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumsOriginal = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drums = new List<int>() { };

            for (int i = 0; i < drumsOriginal.Count; i++)
            {
                drums.Add(drumsOriginal[i]);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }

                int power = int.Parse(input);

                for (int i = 0; i < drums.Count; i++)
                {
                    if (drums[i] == -111)
                    {
                        continue;
                    }

                    drums[i] -= power;

                    if (drums[i] <= 0)
                    {
                        // Buy new
                        double price = drumsOriginal[i] * 3.0;

                        if (price > savings)
                        {
                            // remove drum
                            drums[i] = -111;
                        }
                        else
                        {
                            savings -= price;
                            drums[i] = drumsOriginal[i];
                        }

                    }
                }
            }

            Console.WriteLine(String.Join(" ", drums.Where(x => x != -111).ToList()));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");

        }
    }
}
