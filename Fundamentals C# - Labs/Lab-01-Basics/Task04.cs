using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesAfter = minutes + 30;
            int hoursAfter = hours;

            if (minutesAfter > 60)
            {
                hoursAfter += 1;
                minutesAfter -= 60;
            }

            if (hoursAfter > 23)
            {
                hoursAfter = 0;
            }

            Console.WriteLine($"{hoursAfter}:{minutesAfter:D2}");
        }
    }
}