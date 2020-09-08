using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashes = 0;
            int mouseTrashes = 0;
            int keyboardTrashes = 0;
            int displayTrashes = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    // headset
                    headsetTrashes++;
                }

                if (i % 3 == 0)
                {
                    // mouse
                    mouseTrashes++;
                }

                if (i % 6 == 0)
                {
                    // keyboard
                    keyboardTrashes++;

                    if (keyboardTrashes % 2 == 0)
                    {
                        // display
                        displayTrashes++;
                    }
                }
            }

            double expenses = headsetTrashes * headsetPrice + mouseTrashes * mousePrice + keyboardTrashes * keyboardPrice + displayTrashes * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}