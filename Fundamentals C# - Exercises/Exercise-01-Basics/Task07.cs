using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double money = 0;

            while (input != "Start")
            {
                double curr = double.Parse(input);

                if (curr == 2 || curr == 1 || curr == 0.5 || curr == 0.2 || curr == 0.1)
                {
                    money += curr;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", curr);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                double moneyNeeded = 0;
                string product = String.Empty;

                if (input == "Nuts")
                {
                    moneyNeeded = 2.0;
                    product = "nuts";
                }
                else if (input == "Water")
                {
                    moneyNeeded = 0.7;
                    product = "water";
                }
                else if (input == "Crisps")
                {
                    moneyNeeded = 1.5;
                    product = "crisps";
                }
                else if (input == "Soda")
                {
                    moneyNeeded = 0.8;
                    product = "soda";
                }
                else if (input == "Coke")
                {
                    moneyNeeded = 1.0;
                    product = "coke";
                }

                if (product == String.Empty)
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    if (moneyNeeded > money)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= moneyNeeded;
                        Console.WriteLine("Purchased {0}", product);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Change: {0:f2}", money);

        }
    }
}