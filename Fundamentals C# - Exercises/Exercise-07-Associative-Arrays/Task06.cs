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

            while (input != "end")
            {
                string[] options = input.Split(new string[] { " : " }, StringSplitOptions.None);

                string uni = options[0];
                string student = options[1];

                if (dict.ContainsKey(uni))
                {
                    dict[uni].Add(student);
                }
                else
                {
                    List<string> temp = new List<string>() { };

                    temp.Add(student);

                    dict.Add(uni, temp);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}