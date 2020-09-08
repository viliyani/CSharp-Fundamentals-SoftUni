using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            /*
                        Friday      Saturday        Sunday
            Students    8.45        9.80        10.46
            Business    10.90       15.60       16
            Regular     15          20          22.50
    
            */

            double unitPrice = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    unitPrice = 8.45;
                }
                else if (day == "Saturday")
                {
                    unitPrice = 9.80;
                }
                else if (day == "Sunday")
                {
                    unitPrice = 10.46;
                }

                if (people >= 30)
                {
                    unitPrice -= unitPrice * 0.15;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    unitPrice = 10.90;
                }
                else if (day == "Saturday")
                {
                    unitPrice = 15.60;
                }
                else if (day == "Sunday")
                {
                    unitPrice = 16;
                }

                if (people >= 100)
                {
                    people -= 10;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    unitPrice = 15;
                }
                else if (day == "Saturday")
                {
                    unitPrice = 20;
                }
                else if (day == "Sunday")
                {
                    unitPrice = 22.50;
                }

                if (people >= 10 && people <= 20)
                {
                    unitPrice -= unitPrice * 0.05;
                }
            }

            double total = people * unitPrice;

            Console.WriteLine($"Total price: {total:f2}");

        }
    }
}