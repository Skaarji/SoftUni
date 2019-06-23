using System;
using System.Linq;
using System.Collections.Generic;

namespace teamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> listOfTeams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] command = Console.ReadLine().Split('-');
                if (listOfTeams.Select(x => x.TeamName).Contains(command[1]))
                {
                    Console.WriteLine($"Team {command[1]} was already created!");
                    continue;
                }
                else if (listOfTeams.Select(x => x.Creator).Contains(command[0]))
                {
                    Console.WriteLine($"{command[0]} cannot create another team!");
                    continue;
                }
                List<string> membersList = new List<string>();
                Team team = new Team();
                team.Creator = command[0];
                team.TeamName = command[1];
                team.Members = membersList;
                listOfTeams.Add(team);
                Console.WriteLine($"Team {command[1]} has been created by {command[0]}!");
            }
            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] command = input.Split("->");

                if (!listOfTeams.Select(x => x.TeamName).Contains(command[1]))
                {
                    Console.WriteLine($"Team {command[1]} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }
                if (listOfTeams.Select(x => x.Members).Any(x => x.Contains(command[0])) || listOfTeams.Select(x => x.Creator).Contains(command[0]))
                {
                    Console.WriteLine($"Member {command[0]} cannot join team {command[1]}!");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    int teamIndex = listOfTeams.FindIndex(x => x.TeamName == command[1]);
                    listOfTeams[teamIndex].Members.Add(command[0]);
                    input = Console.ReadLine();
                }
                

            }
            var teamsToDisband = listOfTeams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
            var fullTeams = listOfTeams.
            OrderByDescending(x => x.Members.Count).            
            ThenBy(x => x.TeamName).
            Where(x => x.Members.Count > 0);

            foreach (var item in fullTeams)
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.Creator}");
                foreach (var member in item.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }


    }
}
