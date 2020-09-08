using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int t = 0;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                if (str == "(")
                {
                    t++;
                }
                else if (str == ")")
                {
                    t--;
                }
            }

            if (t == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}