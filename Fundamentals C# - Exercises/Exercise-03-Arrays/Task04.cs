using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = int.Parse(Console.ReadLine());

            for (int j = 0; j < r; j++)
            {
                int first = arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[arr.Length - 1] = first;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}