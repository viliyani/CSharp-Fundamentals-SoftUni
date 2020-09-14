using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            catalog.Cars = new List<Car>();
            catalog.Trucks = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] options = input.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

                if (options[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = options[1];
                    car.Model = options[2];
                    car.HorsePower = int.Parse(options[3]);

                    catalog.Cars.Add(car);
                }
                else if (options[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = options[1];
                    truck.Model = options[2];
                    truck.Weight = int.Parse(options[3]);

                    catalog.Trucks.Add(truck);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }

    class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
}
