using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int) (years * 365.2422);
            int hours = 24 * days;
            long minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}