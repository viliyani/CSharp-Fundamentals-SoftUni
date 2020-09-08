using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lastIdx = 0;
            int lastNum = arr[0];
            int maxSequence = 1;
            int maxFrom = 0;
            int maxTo = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != lastNum)
                {
                    if (i - lastIdx + 1 > maxSequence)
                    {
                        maxSequence = i - lastIdx + 1;
                        maxFrom = lastIdx;
                        maxTo = i;
                    }

                    lastNum = arr[i];
                    lastIdx = i;
                }
            }

            if (arr.Length > 1 && arr.Length - lastIdx + 1 > maxSequence)
            {
                maxFrom = lastIdx;
                maxTo = arr.Length;
            }

            for (int i = maxFrom; i < maxTo; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}