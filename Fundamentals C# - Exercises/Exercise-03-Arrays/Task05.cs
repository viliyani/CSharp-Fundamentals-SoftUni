using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] top = new int[arr.Length];

            int max = -1;
            int idx = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    top[idx++] = arr[i];
                }
            }

            for (int i = idx - 1; i >= 0; i--)
            {
                Console.Write(top[i] + " ");
            }

            Console.WriteLine();

        }
    }
}