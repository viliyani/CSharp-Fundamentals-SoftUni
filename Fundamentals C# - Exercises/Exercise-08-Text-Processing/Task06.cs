using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string result = String.Empty;
            int idx = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    result += str[0];
                }
                else
                {
                    if (str[i] != result[idx])
                    {
                        result += str[i];
                        idx++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}