using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            while (list.Contains(bombNumber))
            {
                int idx = list.IndexOf(bombNumber);

                int leftNumbers = idx - bombPower;
                int rightNumbers = idx + bombPower;

                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }

                if (rightNumbers > list.Count - 1)
                {
                    rightNumbers = list.Count - 1;
                }

                list.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);
            }

            Console.WriteLine(list.Sum());
        }
    }
}