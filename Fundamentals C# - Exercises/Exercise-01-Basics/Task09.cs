using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyIvancho = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double singleSabrePrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());

            double totalSabrePrice = singleSabrePrice * Math.Ceiling(studentsCount * 1.0 + studentsCount * 0.1);
            double totalRobePrice = singleRobePrice * studentsCount;
            double totalBeltPrice = singleBeltPrice * (studentsCount - (studentsCount / 6));

            double total = totalSabrePrice + totalRobePrice + totalBeltPrice;

            if (total <= moneyIvancho)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - moneyIvancho:f2}lv more.");
            }

        }
    }
}