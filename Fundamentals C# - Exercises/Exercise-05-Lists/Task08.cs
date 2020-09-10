using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();


            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] options = input.Split();

                if (options[0] == "merge")
                {
                    int startIdx = int.Parse(options[1]);
                    int endIdx = int.Parse(options[2]);

                    Merge(strings, startIdx, endIdx);
                }
                else if (options[0] == "divide")
                {
                    int idx = int.Parse(options[1]);
                    int partions = int.Parse(options[2]);

                    Divide(strings, idx, partions);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", strings));

        }

        static void Merge(List<string> strings, int start, int end)
        {
            int from = start;
            int to = end;

            if (start < 0)
            {
                from = 0;
            }
            else if (start > strings.Count - 1)
            {
                from = strings.Count - 1;
            }

            if (end < 0)
            {
                to = 0;
            }
            else if (end > strings.Count - 1)
            {
                to = strings.Count - 1;
            }

            string merged = String.Join("", strings.GetRange(from, to - from + 1));

            strings.RemoveRange(from, to - from + 1);

            strings.Insert(from, merged);
        }

        static void Divide(List<string> strings, int idx, int partions)
        {
            // new list
            List<string> parts = new List<string>() { };
            string str = strings[idx];

            // divide
            int cnt = strings[idx].Length;

            if (cnt % partions == 0)
            {
                int step = str.Length / partions;

                for (int i = 0; i < str.Length; i += step)
                {
                    parts.Add(str.Substring(i, step));
                }
            }
            else
            {
                int step = str.Length / partions;

                int br = 1;
                for (int i = 0; i < str.Length; i += step)
                {
                    parts.Add(str.Substring(i, step));
                    if (br++ >= partions - 1)
                    {
                        break;
                    }
                }

                parts.Add(str.Substring((partions - 1) * step, str.Length - ((partions - 1) * step)));
            }

            // remove at index
            strings.RemoveAt(idx);

            // insert range
            strings.InsertRange(idx, parts);
        }

    }
}
