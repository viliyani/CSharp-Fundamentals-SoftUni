using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            int finishIdx = numbers.Count / 2;

            double leftCar = 0;
            double rightCar = 0;

            // left car
            for (int i = 0; i < finishIdx; i++)
            {
                if (numbers[i] == 0)
                {
                    leftCar -= leftCar * 0.20;
                }
                else
                {
                    leftCar += numbers[i];
                }
            }

            // right car
            for (int i = finishIdx + 1; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                {
                    rightCar -= rightCar * 0.20;
                }
                else
                {
                    rightCar += numbers[i];
                }
            }

            if (leftCar < rightCar)
            {
                Console.WriteLine($"The winner is left with total time: {leftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCar}");
            }

        }
    }
}
