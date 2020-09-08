using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            foreach (var item in items)
            {
                bool isOk = true;
                for (int i = 0; i < item.Length; i++)
                {
                    if (!(char.IsLetter(item[i]) || char.IsDigit(item[i]) || item[i] == '_' || item[i] == '-'))
                    {
                        isOk = false;
                        break;
                    }
                }

                if (isOk && item.Length >= 3 && item.Length <= 16)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}