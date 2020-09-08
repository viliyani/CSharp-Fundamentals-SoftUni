using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] one = Console.ReadLine().Split();
            string[] two = Console.ReadLine().Split();

            for (int i = 0; i < two.Length; i++)
            {
                for (int j = 0; j < one.Length; j++)
                {
                    if (two[i] == one[j])
                    {
                        Console.Write(two[i] + " ");
                    }
                }
            }
            Console.WriteLine();
            
        }
    }
}