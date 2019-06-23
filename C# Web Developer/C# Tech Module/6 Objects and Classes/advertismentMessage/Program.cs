using System;
using System.Collections.Generic;
using System.Linq;


namespace advertismentMessage
{
    class Program
    { 
        static Random rnd = new Random();  

    
        static void Main(string[] args)
        {                      
            string[] Phrases = new string[] {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."};
            string[] Events = new string[] {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            
            int adverstisments = int.Parse(Console.ReadLine());
            for (int i = 0; i < adverstisments; i++)
            {
                int randomPhrase = rnd.Next(0, Phrases.Length );
                int randomEvent = rnd.Next(0, Events.Length );
                int randomAuthor = rnd.Next(0, Authors.Length );
                int randomCity = rnd.Next(0, Cities.Length );
                Console.WriteLine($"{Phrases[randomPhrase]} {Events[randomEvent]} {Authors[randomAuthor]} - {Cities[randomCity]}");
            }


        }
    }
}
