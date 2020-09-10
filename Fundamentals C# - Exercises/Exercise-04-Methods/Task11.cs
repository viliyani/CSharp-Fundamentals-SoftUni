using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] options = input.Split();

                if (options[0] == "exchange")
                {
                    int idx = int.Parse(options[1]);

                    if (idx < 0 || idx > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        arr = Exchange(arr, idx);
                    }
                }
                else if (options[0] == "max" && options[1] == "even")
                {
                    MaxEven(arr);
                }
                else if (options[0] == "max" && options[1] == "odd")
                {
                    MaxOdd(arr);
                }
                else if (options[0] == "min" && options[1] == "even")
                {
                    MinEven(arr);
                }
                else if (options[0] == "min" && options[1] == "odd")
                {
                    MinOdd(arr);
                }
                else if (options[0] == "first")
                {
                    int cnt = int.Parse(options[1]);

                    if (cnt < 1 || cnt > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        bool isEven = true;
                        if (options[2] == "odd")
                        {
                            isEven = false;
                        }
                        List<int> result = FirstXElements(arr, cnt, isEven);
                        if (result.Count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine("[" + String.Join(", ", result) + "]");
                        }
                    }
                }
                else if (options[0] == "last")
                {
                    int cnt = int.Parse(options[1]);

                    if (cnt < 1 || cnt > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        bool isEven = true;
                        if (options[2] == "odd")
                        {
                            isEven = false;
                        }
                        List<int> result = LastXElements(arr, cnt, isEven);
                        if (result.Count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine("[" + String.Join(", ", result) + "]");
                        }
                    }
                }
                else
                {
                }

            }

            Console.WriteLine("[" + String.Join(", ", arr) + "]");

        }

        static List<int> FirstXElements(int[] arr, int cnt, bool isEven)
        {
            List<int> result = new List<int>() { };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && isEven == true)
                {
                    result.Add(arr[i]);
                }
                else if (arr[i] % 2 != 0 && isEven == false)
                {
                    result.Add(arr[i]);
                }
                if (result.Count >= cnt)
                {
                    break;
                }
            }

            return result;
        }

        static List<int> LastXElements(int[] arr, int cnt, bool isEven)
        {
            List<int> result = new List<int>() { };

            for (int i = arr.Length-1; i >=0; i--)
            {
                if (arr[i] % 2 == 0 && isEven == true)
                {
                    result.Add(arr[i]);
                }
                else if (arr[i] % 2 != 0 && isEven == false)
                {
                    result.Add(arr[i]);
                }
                if (result.Count >= cnt)
                {
                    break;
                }
            }

            result.Reverse();

            return result;
        }

        static void MaxEven(int[] arr)
        {
            int maxElement = int.MinValue;
            int maxIdx = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num % 2 == 0)
                {
                    if (num >= maxElement)
                    {
                        maxElement = num;
                        maxIdx = i;
                    }
                }
            }

            if (maxElement == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIdx);
            }
        }

        static void MaxOdd(int[] arr)
        {
            int maxElement = int.MinValue;
            int maxIdx = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num % 2 != 0)
                {
                    if (num >= maxElement)
                    {
                        maxElement = num;
                        maxIdx = i;
                    }
                }
            }

            if (maxElement == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIdx);
            }
        }

        static void MinEven(int[] arr)
        {
            int minElement = int.MaxValue;
            int minIdx = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num % 2 == 0)
                {
                    if (num <= minElement)
                    {
                        minElement = num;
                        minIdx = i;
                    }
                }
            }

            if (minElement == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIdx);
            }
        }

        static void MinOdd(int[] arr)
        {
            int minElement = int.MaxValue;
            int minIdx = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num % 2 != 0)
                {
                    if (num <= minElement)
                    {
                        minElement = num;
                        minIdx = i;
                    }
                }
            }

            if (minElement == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }else
            {
                Console.WriteLine(minIdx);
            }
        }

        static int[] Exchange(int[] arr, int idx)
        {
            int[] newArr = new int[arr.Length];

            int arrIdx = 0;

            for (int i = idx + 1; i < arr.Length; i++)
            {
                newArr[arrIdx++] = arr[i];
            }

            for (int i = 0; i <= idx; i++)
            {
                newArr[arrIdx++] = arr[i];
            }

            return newArr;
        }
    }
}
