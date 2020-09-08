using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder() { };

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input[0] == '0')
                {
                    sb.Append(" ");
                }
                else if (input[0] == '2')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("a");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("b");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("c");
                    }
                }
                else if (input[0] == '3')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("d");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("e");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("f");
                    }
                }
                else if (input[0] == '4')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("g");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("h");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("i");
                    }
                }
                else if (input[0] == '5')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("j");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("k");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("l");
                    }
                }
                else if (input[0] == '6')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("m");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("n");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("o");
                    }
                }
                else if (input[0] == '7')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("p");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("q");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("r");
                    }
                    else if (input.Length == 4)
                    {
                        sb.Append("s");
                    }
                }
                else if (input[0] == '8')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("t");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("u");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("v");
                    }
                }
                else if (input[0] == '9')
                {
                    if (input.Length == 1)
                    {
                        sb.Append("w");
                    }
                    else if (input.Length == 2)
                    {
                        sb.Append("x");
                    }
                    else if (input.Length == 3)
                    {
                        sb.Append("y");
                    }
                    else if (input.Length == 4)
                    {
                        sb.Append("z");
                    }
                }
            }

            Console.WriteLine(sb.ToString());

        }
    }
}