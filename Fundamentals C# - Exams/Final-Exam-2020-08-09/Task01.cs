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

                if (input == "Travel") {
                    break;
                }

                string[] options = input.Split(new string[] {":"}, StringSplitOptions.None);

                if (options[0] == "Add Stop") {
                    int idx = int.Parse(options[1]);
                    string str = options[2];

                    if (idx >= 0 && idx < sb.ToString().Length) {
                        sb.Insert(idx, str);
                    }

                    Console.WriteLine(sb);
                } else if (options[0] == "Remove Stop") {
                    int idxStart = int.Parse(options[1]);
                    int idxEnd = int.Parse(options[2]);

                    if (idxStart >= 0 && idxStart < sb.ToString().Length && idxEnd >= 0 && idxEnd < sb.ToString().Length) {
                        // remove stop
                        sb.Remove(idxStart, (idxEnd-idxStart+1));
                    }
                    Console.WriteLine(sb);
                } else if (options[0] == "Switch") {
                    string str = options[1];
                    string repl = options[2];

                    sb.Replace(str, repl);

                    Console.WriteLine(sb);
                }

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {sb.ToString()}");
        }
    }
}