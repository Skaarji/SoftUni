using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<string> usernames = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                if (!usernames.Contains(input))
                {
                    usernames.Add(input);
                }
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }

        }
    }
}
