using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int[] bestArr = new int[n];
            int bestSum = 0;
            int bestLength = 0;
            int bestStartIdx = n;
            int bestLoopIdx = -1;

            int wi = 1;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                arr = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int length = 0;
                int startIdx = 0;
                int sum = arr.Sum();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        length++;
                    }
                    else
                    {
                        bool isCurrentBest = false;
                        if (length > bestLength)
                        {
                            isCurrentBest = true;
                        }
                        else if (length == bestLength)
                        {
                            if (startIdx < bestStartIdx)
                            {
                                isCurrentBest = true;
                            }
                            else if (startIdx == bestStartIdx)
                            {
                                if (sum > bestSum)
                                {
                                    isCurrentBest = true;
                                }
                            }
                        }

                        if (isCurrentBest)
                        {
                            bestLength = length;
                            bestSum = sum;
                            bestStartIdx = startIdx;
                            bestArr = arr;
                            bestLoopIdx = wi;
                        }

                        length = 0;
                        startIdx = i + 1;
                    }
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestSum = sum;
                    bestStartIdx = startIdx;
                    bestArr = arr;
                    bestLoopIdx = wi;
                }

                wi++;
            }

            Console.WriteLine($"Best DNA sample {bestLoopIdx} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestArr));
        }
    }
}
