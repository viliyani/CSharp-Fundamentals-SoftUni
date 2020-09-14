using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            StringBuilder sb = new StringBuilder() {};

            sb.Append(message);

            while (true) {
                string input = Console.ReadLine();

                if (input == "Reveal") {
                    break;
                }

                string[] options = input.Split(new string[] {":|:"}, StringSplitOptions.None);

                if (options[0] == "InsertSpace") {
                    int idx = int.Parse(options[1]);

                    sb.Insert(idx, " ");

                    Console.WriteLine(sb);
                } else if (options[0] == "Reverse") {
                    string str = options[1];

                    string temp = sb.ToString();
                    int idxOf = temp.IndexOf(str);

                    if (idxOf != -1) {
                        StringBuilder reversed = new StringBuilder() {};

                        // Reverse 
                        for (int i = str.Length - 1; i >= 0; i--) {
                            reversed.Append(str[i]);
                        }

                        // Remove
                        sb.Remove(idxOf, str.Length);

                        // Append
                        sb.Append(reversed.ToString());

                        Console.WriteLine(sb);
                    } else {
                        Console.WriteLine("error");
                    }
                } else if (options[0] == "ChangeAll") {
                    string subs = options[1];
                    string repl = options[2];

                    sb.Replace(subs, repl);

                    Console.WriteLine(sb);
                }

            }

            Console.WriteLine($"You have a new text message: {sb.ToString()}");
        }
    }
}