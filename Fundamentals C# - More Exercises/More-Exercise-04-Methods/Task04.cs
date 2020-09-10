using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Trib(n);
        }

        static void Trib(int x)
        {
            if (x == 1)
            {
                Console.WriteLine("1");
            }
            else if (x == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (x == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                int x1 = 1;
                int x2 = 1;
                int x3 = 2;

                Console.Write("1 1 2 ");

                for (int i = 4; i <= x; i++)
                {
                    int curr = x3 + x2 + x1;
                    Console.Write(curr + " ");

                    x1 = x2;
                    x2 = x3;
                    x3 = curr;
                }

                Console.WriteLine();
            }
        }
    }
}
