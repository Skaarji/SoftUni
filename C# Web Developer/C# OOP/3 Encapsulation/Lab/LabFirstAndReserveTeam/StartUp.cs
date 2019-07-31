using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            while (n-->0)
            {
                string[] token = Console.ReadLine().Split();
                Person p = new Person(token[0], token[1], int.Parse(token[2]), decimal.Parse(token[3]));
                people.Add(p);
            }
            
            Team team = new Team("SoftUni");

            foreach (Person person in people)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        }
    }
}
