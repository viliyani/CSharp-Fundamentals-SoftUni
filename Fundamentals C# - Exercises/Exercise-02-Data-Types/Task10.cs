using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double originalN = N;
            int cnt = 0;

            while (N >= M)
            {
                cnt++;
                N -= M;

                if ((N / originalN) * 100 == 50.000)
                {
                    int a = (int)N;
                    int b = (int)Y;
                    int res = a / b;
                    N = (double)res;
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(cnt);

        }
    }
}