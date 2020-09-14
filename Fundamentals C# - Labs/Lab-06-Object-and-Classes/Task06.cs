using System;
using System.Collections.Generic;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] info = input.Split();

                bool studentExists = false;
                int idx = 0;
                foreach (var student in students)
                {
                    if (student.FirstName == info[0] && student.LastName == info[1])
                    {
                        studentExists = true;
                        break;
                    }
                    idx++;
                }

                if (studentExists == true)
                {
                    students[idx].Age = int.Parse(info[2]);
                    students[idx].Hometown = info[3];
                }
                else
                {
                    students.Add(new Student(input));
                }
            }

            string option = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Hometown == option)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public Student(string input)
        {
            string[] options = input.Split();
            FirstName = options[0];
            LastName = options[1];
            Age = int.Parse(options[2]);
            Hometown = options[3];
        }
    }
}
