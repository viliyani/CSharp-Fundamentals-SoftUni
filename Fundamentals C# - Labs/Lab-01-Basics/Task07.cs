using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (type == "Weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
            }
            else if (type == "Weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            else if (type == "Holiday")
            {
                if ((age >= 0 && age <= 18))
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }

            if (price == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}