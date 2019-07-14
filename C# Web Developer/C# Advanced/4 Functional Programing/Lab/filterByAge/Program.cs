using System;
using System.Collections.Generic;
using System.Linq;

namespace filterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                people.Add(new KeyValuePair<string, int>(input[0], int.Parse(input[1])));

            }
            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            string printType = Console.ReadLine();

            people =people.Where(p => filter == "younger" ? p.Value < filterAge : p.Value >= filterAge)
                .ToList();

            foreach (var person in people)
            {
                if (printType == "name")
                {
                    Console.WriteLine(person.Key);
                }
                else if (printType == "age")
                {
                    Console.WriteLine(person.Value);
                }
                else
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
                                          
        }
        //static Func<KeyValuePair<string, int>, string, string> Print
        //{

        //}
    }
}
