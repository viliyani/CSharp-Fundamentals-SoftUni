using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] options = command.Split();

                if (options[0] == "Add")
                {
                    AddContact(contacts, options[1], int.Parse(options[2]));
                }
                else if (options[0] == "Remove")
                {
                    RemoveContact(contacts, int.Parse(options[1]));
                }
                else if (options[0] == "Export")
                {
                    Export(contacts, int.Parse(options[1]), int.Parse(options[2]));
                }
                else if (options[0] == "Print")
                {
                    if (options[1] == "Normal")
                    {
                        Print(contacts, false);
                    }
                    else if (options[1] == "Reversed")
                    {
                        Print(contacts, true);
                    }

                    break;
                }
            }

        }

        static void Print(List<string> contacts, bool orderBy)
        {
            if (orderBy == false)
            {
                // Asc
                Console.Write("Contacts: ");
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.Write(contacts[i] + " ");
                }
            }
            else
            {
                // Desc
                Console.Write("Contacts: ");
                for (int i = contacts.Count - 1; i >= 0; i--)
                {
                    Console.Write(contacts[i] + " ");
                }
            }
        }

        static void AddContact(List<string> contacts, string contact, int index)
        {
            if (contacts.Contains(contact))
            {
                if (index >= 0 && index < contacts.Count)
                {
                    contacts.Insert(index, contact);
                }
            }
            else
            {
                contacts.Add(contact);
            }
        }

        static void RemoveContact(List<string> contacts, int index)
        {
            if (index >= 0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
            }
        }

        static void Export(List<string> contacts, int index, int count)
        {
            int br = 1;
            for (int i = index; i < contacts.Count; i++)
            {
                if (br <= count)
                {
                    Console.Write(contacts[i] + " ");
                }
                else
                {
                    break;
                }
                br++;
            }
            Console.WriteLine();
        }
    }
}