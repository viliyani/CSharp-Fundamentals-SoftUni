using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, int>() { };
            var junk = new Dictionary<string, int>() { };

            dict.Add("shards", 0);
            dict.Add("fragments", 0);
            dict.Add("motes", 0);

            bool doWhile = true;

            while (doWhile)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int qty = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (dict.ContainsKey(material))
                        {
                            dict[material] += qty;
                        }

                        if (dict[material] >= 250 && material == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            dict[material] -= 250;
                            doWhile = false;
                            break;
                        }
                        else if (dict[material] >= 250 && material == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                            dict[material] -= 250;
                            doWhile = false;
                            break;
                        }
                        else if (dict[material] >= 250 && material == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            dict[material] -= 250;
                            doWhile = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += qty;
                        }
                        else
                        {
                            junk.Add(material, qty);
                        }
                    }
                }
            }

            foreach (var item in dict.OrderByDescending(key => key.Value).ThenBy(key => key.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


            foreach (var item in junk.OrderBy(key => key.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}