using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (bigNumber[0] == '0')
            {
                bigNumber = bigNumber.Substring(1);
            }

            StringBuilder sb = new StringBuilder();

            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int current = int.Parse(bigNumber[i].ToString()) * num + remainder;
                remainder = 0;

                if (current > 9)
                {
                    remainder = current / 10;
                    current = current % 10;
                }

                sb.Append(current);
            }

            if (remainder > 0)
            {
                sb.Append(remainder);
            }

            StringBuilder result = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                result.Append(sb[i]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}