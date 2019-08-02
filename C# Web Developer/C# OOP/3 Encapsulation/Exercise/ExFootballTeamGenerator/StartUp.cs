using ExFootballTeamGenerator.Exceptions;
using ExFootballTeamGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExFootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                string[] tokens = input.Split(';', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Team")
                {
                    Team team = new Team(tokens[1]);
                    if (!teams.Any(x => x.Name == tokens[1]))
                    {
                        teams.Add(team);
                    }
                }
                else if (tokens[0] == "Add")
                {
                    CheckIfTeamExists(teams, tokens);

                    Player player = new Player
                        (
                                    tokens[2]
                        , int.Parse(tokens[3])
                        , int.Parse(tokens[4])
                        , int.Parse(tokens[5])
                        , int.Parse(tokens[6])
                        , int.Parse(tokens[7])
                        );
                    int index = teams.FindIndex(x => x.Name == tokens[1]);
                    teams[index].AddPlayer(player);

                }
                else if (tokens[0]=="Remove")
                {

                    int index = teams.FindIndex(x => x.Name == tokens[1]);
                    teams[index].RemovePlayer(tokens[2],tokens[1]);

                }
                else if (tokens[0]=="Rating")
                {
                    CheckIfTeamExists(teams, tokens);
                    int index = teams.FindIndex(x => x.Name == tokens[1]);
                    Console.WriteLine($"{teams[index].Name} - {teams[index].Rating()}"); 
                }
                
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
                input = Console.ReadLine();
            }
        }

        private static void CheckIfTeamExists(List<Team> teams, string[] tokens)
        {
            if (!teams.Any(x => x.Name == tokens[1]))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.addToMissingTeam, tokens[1]));
            }
        }
    }
}
