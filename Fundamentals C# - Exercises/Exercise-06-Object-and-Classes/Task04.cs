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

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None);
                students.Add(new Student(input[0], input[1], double.Parse(input[2])));
            }

            foreach (var item in students.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string FirstNamePar, string LastNamePar, double GradePar)
        {
            FirstName = FirstNamePar;
            LastName = LastNamePar;
            Grade = GradePar;
        }
    }

}
