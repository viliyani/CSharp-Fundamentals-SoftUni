using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder() { };

            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());

                sb.Append((char)(c + key));
            }

            Console.WriteLine(sb.ToString());

        }
    }
}