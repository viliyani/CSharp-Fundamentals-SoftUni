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

            List<Employee> items = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                items.Add(new Employee(options[0], double.Parse(options[1]), options[2]));
            }

            List<string> departments = new List<string>();
            List<double> avgs = new List<double>();

            foreach (var item in items.Select(x => x.Department))
            {
                if (!departments.Contains(item))
                {
                    departments.Add(item);
                    avgs.Add(items.Where(x => x.Department == item).Average(y => y.Salary));
                }
            }

            int idx = -1;
            double maxAvg = -1;
            string bestDepartment = String.Empty;
            for (int i = 0; i < avgs.Count; i++)
            {
                if (avgs[i] > maxAvg)
                {
                    maxAvg = avgs[i];
                    idx = i;
                    bestDepartment = departments[i];
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (var item in items.Where(x => x.Department == bestDepartment).OrderByDescending(y => y.Salary).ToList())
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
}
