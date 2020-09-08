using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            double totalSpent = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Game Time")
                {
                    break;
                }

                double price = 0;

                if (input == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (input == "CS: OG")
                {
                    price = 15.99;
                }
                else if (input == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (input == "Honored 2")
                {
                    price = 59.99;
                }
                else if (input == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }

                if (price == 0)
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else if (currentBalance >= price)
                    {
                        Console.WriteLine($"Bought {input}");
                        currentBalance -= price;
                        totalSpent += price;
                    }
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
            }

        }
    }
}