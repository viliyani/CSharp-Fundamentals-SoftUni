using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)(i + 'a'), (char)(j + 'a'), (char)(k + 'a'));
                    }
                }
            }

        }
    }
}