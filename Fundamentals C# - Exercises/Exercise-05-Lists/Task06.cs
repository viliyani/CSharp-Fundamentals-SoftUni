using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cards1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> cards2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (cards1.Count > 0 && cards2.Count > 0)
            {
                if (cards1[0] > cards2[0])
                {
                    cards1.Add(cards1[0]);
                    cards1.Add(cards2[0]);
                }
                else if (cards1[0] < cards2[0])
                {
                    cards2.Add(cards2[0]);
                    cards2.Add(cards1[0]);
                }

                cards1.RemoveAt(0);
                cards2.RemoveAt(0);
            }

            if (cards1.Count > 0 && cards2.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
            }
            else if (cards2.Count > 0 && cards1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
            }
        }
    }
}