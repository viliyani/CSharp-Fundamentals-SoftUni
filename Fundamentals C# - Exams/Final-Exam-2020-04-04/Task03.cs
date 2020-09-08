using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>() { };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] options = input.Split();

                string name = options[0];
                int hp = int.Parse(options[1]);
                int mp = int.Parse(options[2]);

                dict.Add(name, new List<int>() { hp, mp });

            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] options = input.Split(new string[] { " - " }, StringSplitOptions.None);

                if (options[0] == "CastSpell")
                {
                    string name = options[1];
                    int mpNeeded = int.Parse(options[2]);
                    string spellName = options[3];

                    if (dict[name][1] - mpNeeded >= 0)
                    {
                        int mpLeft = dict[name][1] - mpNeeded;
                        dict[name][1] = mpLeft;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {mpLeft} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (options[0] == "TakeDamage")
                {
                    string name = options[1];
                    int damage = int.Parse(options[2]);
                    string attacker = options[3];

                    dict[name][0] -= damage;

                    if (dict[name][0] >= 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {dict[name][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        dict.Remove(name);
                    }
                }
                else if (options[0] == "Recharge")
                {
                    string name = options[1];
                    int amount = int.Parse(options[2]);

                    if (dict[name][1] + amount > 200)
                    {
                        amount = 200 - dict[name][1];
                    }

                    dict[name][1] += amount;

                    Console.WriteLine($"{name} recharged for {amount} MP!");
                }
                else if (options[0] == "Heal")
                {
                    string name = options[1];
                    int amount = int.Parse(options[2]);

                    if (dict[name][0] + amount > 100)
                    {
                        amount = 100 - dict[name][0];
                    }

                    dict[name][0] += amount;

                    Console.WriteLine($"{name} healed for {amount} HP!");
                }
            }

            foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenBy(y => y.Key))
            {
                Console.WriteLine(item.Key);
                
                Console.WriteLine("  HP: {0}", item.Value[0]);
                Console.WriteLine("  MP: {0}", item.Value[1]);
            }

        }
    }
}