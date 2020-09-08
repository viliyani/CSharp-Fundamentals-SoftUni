using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int spice = 0;
            int day = 0;

            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }

            while (true)
            {
                spice += yield;
                spice -= 26;
                yield -= 10;

                day++;


                if (yield < 100)
                {
                    spice -= 26;
                    break;
                }
            }

            Console.WriteLine(day);
            Console.WriteLine(spice);
        }
    }
}