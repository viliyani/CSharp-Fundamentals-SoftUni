using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator(Console.ReadLine());
        }

        static void PasswordValidator(string password)
        {
            bool isValid = true;
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            password = password.ToLower();
            for (int i = 0; i < password.Length; i++)
            {
                if (!((password[i] >= '0' && password[i] <= '9') ||(password[i] >= 'a' && password[i] <= 'z')))
                {
                    isValid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }

            int cnt = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    cnt++;
                }
            }

            if (cnt < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
