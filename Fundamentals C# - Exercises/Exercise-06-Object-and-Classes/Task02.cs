using System;

namespace ObjectAndClasses
{
    class Program
    {
        public static object Spli { get; private set; }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

                if (options[0] =="Edit")
                {
                    article.Edit(options[1]);
                }
                else if (options[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(options[1]);
                }
                else if (options[0] == "Rename")
                {
                    article.Rename(options[1]);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string TitlePar, string ContentPar, string AuthorPar)
        {
            Title = TitlePar;
            Content = ContentPar;
            Author = AuthorPar;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
