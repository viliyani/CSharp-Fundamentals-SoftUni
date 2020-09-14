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

                cars.Add(new Car(options[0], double.Parse(options[1]), double.Parse(options[2])));
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] options = input.Split();

                Car car = cars.Find(x => x.Model == options[1]);
                double kms = double.Parse(options[2]);

                if (car.CanMove(kms))
                {
                    car.Drive(kms);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.Fuel:f2} {item.Distance:f0}");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Consumption { get; set; }
        public double Distance { get; set; }

        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
            Distance = 0;
        }

        public bool CanMove(double kms)
        {
            if (Consumption * kms <= Fuel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Drive(double kms)
        {
            Fuel -= Consumption * kms;
            Distance += kms;
        }
    }
}
