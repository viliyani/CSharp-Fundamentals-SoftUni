using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder() { };
            sb.Append(text);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                string[] options = input.Split();

                if (input == "TakeOdd")
                {
                    StringBuilder temp = new StringBuilder() { };
                    for (int i = 0; i < sb.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            temp.Append(sb[i]);
                        }
                    }
                    sb = temp;
                    Console.WriteLine(sb);
                }
                else if (options[0] == "Cut")
                {
                    sb.Remove(int.Parse(options[1]), int.Parse(options[2]));
                    Console.WriteLine(sb);
                }
                else if (options[0] == "Substitute")
                {
                    string sstring = options[1];
                    string sstitute = options[2];

                    string temp = sb.ToString();

                    if (temp.IndexOf(sstring) != -1)
                    {
                        temp = temp.Replace(sstring, sstitute);

                        sb.Clear();

                        sb.Append(temp);

                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    
                }
            }

            Console.WriteLine($"Your password is: {sb.ToString()}");

        }
    }
}