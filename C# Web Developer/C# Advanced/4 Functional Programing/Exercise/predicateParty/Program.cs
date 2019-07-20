using System;
using System.Collections.Generic;
using System.Linq;

namespace predicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, int, bool> checkLength = (a, b) => a.Length == b;

            Func<List<string>, List<string>, List<string>> doublePerson = (a, b) =>
             {
                 foreach (string doubled in b)
                 {
                     for (int i = 0; i < a.Count * 2; i++)
                     {
                         if (i < a.Count)
                         {
                             if (a[i] == doubled)
                             {
                                 a.Insert(i, doubled);
                                 i++;
                             }
                         }
                     }
                 }
                 return a;
             };
            List<string> updated = new List<string>();

            while (commands[0] != "Party!")
            {
                
                if (commands[1] == "StartsWith")
                {
                    updated = people
                        .Where(x => startsWith(x, commands[2]))
                        .ToList();
                }
                else if (commands[1] == "EndsWith")
                {
                    updated = people
                        .Where(x => endsWith(x, commands[2]))
                        .Distinct()
                        .ToList();
                }
                else if (commands[1] == "Length")
                {
                    updated = people
                        .Where(x => checkLength(x, int.Parse(commands[2])))
                        .Distinct()
                        .ToList();
                }
                if (commands[0] == "Remove")
                {
                    people =people
                        .Where(x => !updated.Contains(x))
                        .Distinct()
                        .ToList();
                }
                else if (commands[0] == "Double")
                {
                    people = doublePerson(people, updated);
                }
                commands = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            }
            if (people.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
