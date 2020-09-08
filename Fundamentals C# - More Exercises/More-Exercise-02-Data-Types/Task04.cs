using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool flag = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("{0} -> true", i);
                }
                else
                {
                    Console.WriteLine("{0} -> false", i);
                }
            }

        }
    }
}