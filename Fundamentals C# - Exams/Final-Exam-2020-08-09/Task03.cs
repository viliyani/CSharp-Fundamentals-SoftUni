using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Plant {
        public int rarity;
        public double avg;
        public List<int> rating;
    }

    class Program
    {
        static void Main(string[] args)
        {
        	var dict  = new Dictionary<string, Plant> () {};

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                string[] options = Console.ReadLine().Split(new string[] {"<->"}, StringSplitOptions.None);

            	string plant = options[0];
            	int rarity = int.Parse(options[1]);

                if (dict.ContainsKey(plant)) {
                    dict[plant].rarity = rarity;
                } else {
                    var temp = new Plant();
                    temp.rarity = rarity;
                    temp.avg = 0;
                    temp.rating = new List<int>() {};

                    dict.Add(plant, temp);
                }

            }

            while (true) {
            	string input = Console.ReadLine();

            	if (input == "Exhibition") {
            		break;
            	}

                string[] options = input.Split(new string[] {": ", " - "}, StringSplitOptions.RemoveEmptyEntries);

                if (options[0] == "Rate") {
                	string plant = options[1];
                	int rating = int.Parse(options[2]);

                    if (!dict.ContainsKey(plant)) {
                        Console.WriteLine("error");
                    } else {
                        dict[plant].rating.Add(rating);	
                    }

                } else if (options[0] == "Update") {
                	string plant = options[1];
                	int rarity = int.Parse(options[2]);

                    if (!dict.ContainsKey(plant)) {
                        Console.WriteLine("error");
                    } else {
                        dict[plant].rarity = rarity;
                    }

                }
                else if (options[0] == "Reset") {
                	string plant = options[1];
                	
                    if (!dict.ContainsKey(plant)) {
                        Console.WriteLine("error");
                    } else {
                        dict[plant].rating.Clear();
                    }
                } else {
                    Console.WriteLine("error");
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in dict) {
                int cnt = item.Value.rating.Count;
                if (cnt > 0) {
                    int total = 0;

                    for (int i = 0; i < cnt; i++) {
                        total += item.Value.rating[i];
                    }

                    dict[item.Key].avg = total * 1.0 / cnt * 1.0;
                }
            }

            foreach (var item in dict.OrderByDescending(x => x.Value.rarity).ThenByDescending(x => x.Value.avg)) {
	            Console.WriteLine($"- {item.Key}; Rarity: {item.Value.rarity}; Rating: {item.Value.avg:F2}");
            }

        }
    }
}