using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] one = new int[n];
            int[] two = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                if (i % 2 == 0)
                {
                    one[i] = int.Parse(options[0]);
                    two[i] = int.Parse(options[1]);
                }
                else
                {
                    one[i] = int.Parse(options[1]);
                    two[i] = int.Parse(options[0]);
                }
            }

            Console.WriteLine(String.Join(" ", one));
            Console.WriteLine(String.Join(" ", two));
        }
    }
}