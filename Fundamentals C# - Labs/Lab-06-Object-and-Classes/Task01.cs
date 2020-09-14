using System;
using System.Globalization;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime dt = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dt.DayOfWeek);
        }
    }
}
