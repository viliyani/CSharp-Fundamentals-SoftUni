using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int sum = 0;

            while (list.Count > 0)
            {
                int idx = int.Parse(Console.ReadLine());

                int element = 0;

                if (idx < 0)
                {
                    element = list[0];
                    list[0] = list[list.Count - 1];
                }
                else if (idx >= list.Count)
                {
                    element = list[list.Count - 1];
                    list[list.Count - 1] = list[0];
                }
                else
                {
                    element = list[idx];
                    list.RemoveAt(idx);
                }

                sum += element;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= element)
                    {
                        list[i] += element;
                    }
                    else
                    {
                        list[i] -= element;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
