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

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                family.AddMember(new Person(options[0], int.Parse(options[1])));
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            Members = new List<Person>() { };
        }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return Members.OrderByDescending(x => x.Age).First();
        }
    }
}
