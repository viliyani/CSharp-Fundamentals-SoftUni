using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>() { };



            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                string user = options[1];
                
                if (options[0] == "register")
                {
                    string code = options[2];

                    if (dict.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[user]}");
                    }
                    else
                    {
                        dict.Add(user, code);
                        Console.WriteLine($"{user} registered {code} successfully");
                    }
                }
                else if (options[0] == "unregister")
                {
                    if (!dict.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        dict.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}