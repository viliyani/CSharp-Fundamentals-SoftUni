using System;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Song[] songs = new Song[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries);

                songs[i] = new Song(input[0], input[1], input[2]);
            }

            string printOption = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (printOption == "all")
                {
                    Console.WriteLine(songs[i].Name);
                }
                else if (printOption == songs[i].TypeList)
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string TypeList, string Name, string Time)
        {
            this.TypeList = TypeList;
            this.Name = Name;
            this.Time = Time;
        }
    }
}
