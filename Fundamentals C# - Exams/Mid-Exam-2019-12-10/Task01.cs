using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double totalSaved = 0;

            for (int i = 1; i <= months; i++)
            {
                double monthSave = money * 0.25;
                if (i % 2 != 0 && i != 1)
                {
                    totalSaved -= totalSaved * 0.16;
                }

                if (i % 4 == 0)
                {
                    monthSave += totalSaved * 0.25;
                }

                totalSaved += monthSave;
            }

            if (totalSaved >= money)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {totalSaved - money:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {money - totalSaved:f2}lv. more.");
            }
        }
    }
}