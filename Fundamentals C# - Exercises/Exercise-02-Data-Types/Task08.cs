using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggest = -1;
            string name = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > biggest)
                {
                    biggest = volume;
                    name = model;
                }
            }

            Console.WriteLine(name);

        }
    }
}