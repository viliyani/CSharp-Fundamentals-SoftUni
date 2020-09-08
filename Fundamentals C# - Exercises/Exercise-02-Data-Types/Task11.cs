using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double maxValue = -1;
            int maxSnow = -1;
            int maxTime = -1;
            int maxQuality = -1;

            for (int i = 0; i < N; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                double value = Math.Pow((snow * 1.0 / time * 1.0), quality * 1.0);

                if (value > maxValue)
                {
                    maxValue = value;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}