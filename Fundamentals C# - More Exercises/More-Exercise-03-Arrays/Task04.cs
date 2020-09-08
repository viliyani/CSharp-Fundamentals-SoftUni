using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = arr.Length;

            int[] arr1 = new int[n / 2];
            int[] arr2 = new int[n / 2];

            // 1. Fill arr1
            int idx1 = 0;
            for (int i = n / 4; i < (3 * n / 4); i++)
            {
                arr1[idx1++] = arr[i];
            }

            // 2. Fill arr2
            int idx2 = 0;
            for (int i = n / 4 - 1; i >= 0; i--)
            {
                arr2[idx2++] = arr[i];
            }

            for (int i = n - 1; i >= (3 * n / 4); i--)
            {
                arr2[idx2++] = arr[i];
            }

            // 3. Sum arr1 and arr2

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write((arr1[i]+arr2[i]) + " ");
            }

            Console.WriteLine();

        }
    }
}
