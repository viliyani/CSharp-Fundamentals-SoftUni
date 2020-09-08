using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&').ToList();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] options = command.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                if (options[0] == "Add Book")
                {
                    string book = options[1];

                    if (!books.Contains(book))
                    {
                        books.Insert(0, book);
                    }
                }
                else if (options[0] == "Take Book")
                {
                    string book = options[1];

                    if (books.Contains(book))
                    {
                        books.Remove(book);
                    }
                }
                else if (options[0] == "Swap Books")
                {
                    string book1 = options[1];
                    string book2 = options[2];

                    if (books.Contains(book1) && books.Contains(book2))
                    {
                        int idx1 = books.IndexOf(book1);
                        int idx2 = books.IndexOf(book2);

                        string temp = books[idx1];
                        books[idx1] = books[idx2];
                        books[idx2] = temp;
                    }
                }
                else if (options[0] == "Insert Book")
                {
                    string book = options[1];

                    books.Add(book);
                }
                else if (options[0] == "Check Book")
                {
                    int idx = int.Parse(options[1]);

                    if (idx >= 0 && idx < books.Count)
                    {
                        Console.WriteLine(books[idx]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", books));
        }
    }
}