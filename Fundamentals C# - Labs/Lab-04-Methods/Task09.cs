using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
        }

        static int GetMax(int a, int b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}