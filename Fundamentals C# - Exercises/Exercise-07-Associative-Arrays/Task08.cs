using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>() { };

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] options = input.Split(new string[] { " -> " }, StringSplitOptions.None);

                string company = options[0];
                string worker = options[1];

                if (dict.ContainsKey(company))
                {
                    if (!dict[company].Contains(worker))
                    {
                        dict[company].Add(worker);
                    }
                }
                else
                {
                    List<string> temp = new List<string>() { };

                    temp.Add(worker);

                    dict.Add(company, temp);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var worker in item.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }
            }

        }
    }
}