using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>() { };

            string peopleInput = Console.ReadLine();
            string[] peopleArr = peopleInput.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < peopleArr.Length; i++)
            {
                string[] options = peopleArr[i].Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(options[0], double.Parse(options[1])));
            }

            string productsInput = Console.ReadLine();
            string[] productsArr = productsInput.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productsArr.Length; i++)
            {
                string[] options = productsArr[i].Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);

                products.Add(new Product(options[0], double.Parse(options[1])));
            }


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] options = input.Split();

                string person = options[0];
                string product = options[1];

                Person personObj = people.Find(x => x.Name == person);
                Product productObj = products.Find(x => x.Name == product);

                if (personObj.Money >= productObj.Cost)
                {
                    personObj.Products.Add(productObj);
                    personObj.Money -= productObj.Cost;
                    Console.WriteLine($"{person} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{person} can't afford {product}");
                }

            }

            foreach (var item in people)
            {
                if (item.Products.Count > 0)
                {
                    Console.WriteLine("{0} - {1}", item.Name, String.Join(", ", item.Products.Select(x => x.Name)));
                }
                else
                {
                    Console.WriteLine("{0} - Nothing bought", item.Name);
                }

            }

        }
    }

    class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>() { };
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
