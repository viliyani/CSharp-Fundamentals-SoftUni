using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
        	var dict  = new Dictionary<string, List<int>> () {};

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
            	string[] options = Console.ReadLine().Split('|');

            	string car = options[0];
            	int mileage = int.Parse(options[1]);
            	int fuel = int.Parse(options[2]);

            	dict.Add(car, new List<int>() {mileage, fuel});

            }

            while (true) {
            	string input = Console.ReadLine();

            	if (input == "Stop") {
            		break;
            	}

                string[] options = input.Split(new string[] {" : "}, StringSplitOptions.None);

                if (options[0] == "Drive") {
                	string car = options[1];
                	int distance = int.Parse(options[2]);
                	int fuel = int.Parse(options[3]);

                	if (dict[car][1] < fuel) {
                		Console.WriteLine("Not enough fuel to make that ride");
                	} else {
                		dict[car][0] += distance;
                		dict[car][1] -= fuel;
                		Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                	}

                	if (dict[car][0] > 100000) {
                		Console.WriteLine($"Time to sell the {car}!");
                		dict.Remove(car);
                	}
                } else if (options[0] == "Refuel") {
                	string car = options[1];
                	int fuel = int.Parse(options[2]);

                	int refill = fuel;

                	if (dict[car][1] + refill > 75) {
                		refill = 75 - dict[car][1];
                	}

                	dict[car][1] += refill;
                	
                	Console.WriteLine($"{car} refueled with {refill} liters");
                }
                else if (options[0] == "Revert") {
                	string car = options[1];
                	int km = int.Parse(options[2]);


                	dict[car][0] -= km;

                	if (dict[car][0] < 10000) {
                		dict[car][0] = 10000;
                	} else {
	                	Console.WriteLine($"{car} mileage decreased by {km} kilometers");
                	}
                }
            }

            foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key)) {
	            Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }

        }
    }
}