using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string a = input[0];
            string b = input[1];

            int sum = 0;

            int n = Math.Min(a.Length, b.Length);

            for (int i = 0; i < n; i++)
            {
                sum += (int)a[i] * (int)b[i];
            }

            if (a.Length > b.Length)
            {
                for (int i = b.Length; i < a.Length; i++)
                {
                    sum += (int)a[i];
                }
            } else if (a.Length < b.Length)
            {
                for (int i = a.Length; i < b.Length; i++)
                {
                    sum += (int)b[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}