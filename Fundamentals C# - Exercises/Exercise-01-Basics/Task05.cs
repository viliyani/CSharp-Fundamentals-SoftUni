using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] charArray = username.ToCharArray();
            Array.Reverse(charArray);

            string reversed = new string(charArray);

            int cnt = 1;

            string password = Console.ReadLine();


            while (true)
            {
                if (password == reversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (cnt++ >= 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }

                password = Console.ReadLine();
            }

        }
    }
}