using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, repeat));
        }

        static string RepeatString(string str, int repeat)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < repeat; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}