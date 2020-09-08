using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBouns = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());

                double currentBonus = studentAttendances * 1.0 / lecturesCount * 1.0 * (5 + initialBouns);

                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendances = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}