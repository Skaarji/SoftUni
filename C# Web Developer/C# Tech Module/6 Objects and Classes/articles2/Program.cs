using System;
using System.Collections.Generic;
using System.Linq;

namespace articles2
{
    class Program
    {

        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            var ListOfArticles = new List<Article>();
            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                //string title = input[0];
                //string content = input[1];
                //string author = input[2];



                var article = new Article(); 

                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];
                ListOfArticles.Add(article);


            }
            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                ListOfArticles = ListOfArticles.OrderBy(x => x.Title)
                .ToList();
            }
            else if (criteria == "content")
            {
                ListOfArticles = ListOfArticles.OrderBy(x => x.Content)
                     .ToList();
            }
            else if (criteria == "author")
            {
                ListOfArticles = ListOfArticles.OrderBy(x => x.Author)
                    .ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, ListOfArticles));

        }

    }
    class Article
    {
        //public Article(string title, string content, string author)
        //{
        //    Title = title;
        //    Content = content;
        //    Author = author;
        //}
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}
