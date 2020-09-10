using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>() { };
            List<char> chars = new List<char>() { };

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    chars.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>() { };
            List<int> skipList = new List<int>() { };

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            StringBuilder sb = new StringBuilder() { };

            int idx = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int get = takeList[i];

                if (takeList[i] != 0)
                {
                    if (idx + get >= chars.Count)
                    {
                        get = chars.Count - idx;
                    }
                    sb.Append(new string(chars.GetRange(idx, get).ToArray()));
                }

                idx += takeList[i] + skipList[i];
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
