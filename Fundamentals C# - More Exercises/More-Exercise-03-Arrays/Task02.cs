using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine(1);
                Console.WriteLine(1 + " " + 1);
            }
            else
            {
                int[] a = new int[n];
                int[] b = new int[n];

                b[0] = 1;
                b[1] = 1;

                Console.WriteLine(1);
                Console.WriteLine(1 + " " + 1);

                for (int row = 3; row <= n; row++)
                {
                    a[0] = 1;
                    a[row - 1] = 1;

                    for (int j = 1; j < row - 1; j++)
                    {
                        a[j] = b[j - 1] + b[j];
                    }

                    a.CopyTo(b, 0);

                    Console.WriteLine(String.Join(" ", a.Where(val => val > 0).ToArray()));
                }
            }

        }
    }
}
