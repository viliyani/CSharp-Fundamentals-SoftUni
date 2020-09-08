using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int power = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == '>')
                {
                    power += int.Parse(str[i + 1].ToString());
                    sb.Append(c);
                }
                else if (power == 0)
                {
                    sb.Append(c);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}