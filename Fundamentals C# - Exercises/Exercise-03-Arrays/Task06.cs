using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool flag = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                // Calc left sum
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                // Calc right sum
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    flag = true;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("no");
            }

        }
    }
}