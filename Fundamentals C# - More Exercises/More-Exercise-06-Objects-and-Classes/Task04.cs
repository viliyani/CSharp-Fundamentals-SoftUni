using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>() { };

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                string model = options[0];
                int speed = int.Parse(options[1]);
                int power = int.Parse(options[2]);
                int weight = int.Parse(options[3]);
                string type = options[4];

                cars.Add(new Car(model, speed, power, weight, type));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var item in cars.Where(x => x.Cargo.Type == "fragile" && x.Cargo.Weight < 1000))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var item in cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }

    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }

    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }

    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }
    }
}
