using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int e1 = int.Parse(Console.ReadLine());
            int e2 = int.Parse(Console.ReadLine());
            int e3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int i = 1;
            int remainingStudents = students;
            int e = e1 + e2 + e3;

            while (remainingStudents > 0)
            {
                if (i % 4 == 0)
                {
                    // rest
                }
                else
                {
                    remainingStudents -= e;
                }

                i++;
            }

            Console.WriteLine($"Time needed: {i - 1}h.");
        }
    }
}