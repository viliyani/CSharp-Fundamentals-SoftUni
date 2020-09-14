using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> items = new List<Vehicle>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] options = input.Split();

                items.Add(new Vehicle(options[0], options[1], options[2], int.Parse(options[3])));

            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                items[items.FindIndex(x => x.Model == input)].PrintInfo();

            }

            double carsAvg = 0;
            double trucksAvg = 0;

            if (items.Where(x => x.Type == "car").ToList().Count > 0)
            {
                carsAvg = items.Where(x => x.Type == "car").ToList().Average(x => x.Horsepower);
            }

            if (items.Where(x => x.Type == "truck").ToList().Count > 0)
            {
                trucksAvg = items.Where(x => x.Type == "truck").Average(x => x.Horsepower);
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAvg:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvg:f2}.");

        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string Type, string Model, string Color, int Horsepower)
        {
            this.Type = Type;
            this.Model = Model;
            this.Color = Color;
            this.Horsepower = Horsepower;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Type: {char.ToUpper(Type[0]) + Type.Substring(1)}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Horsepower: {Horsepower}");
        }
    }


}
