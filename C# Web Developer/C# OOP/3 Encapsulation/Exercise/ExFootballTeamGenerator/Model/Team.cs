using ExFootballTeamGenerator.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExFootballTeamGenerator.Model
{
    public class Team
    {
        private string name;
        private List<Player> players;
        public string Name
        {
            get
            {
                return this.name;

            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.nameInvalid);
                }
                name = value;
            }
        }
        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string playerName, string teamName)
        {
            if (!players.Any(x => x.Name == playerName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.removeMissingPlayer, playerName, teamName));

            }
            int index = players.FindIndex(x => x.Name == playerName);
            this.players.RemoveAt(index);
        }
        public int Rating()
        {
            if (players.Count == 0)
            {
                return 0;
            }
            double sumSkills = 0;
            foreach (var item in players)
            {
                sumSkills += item.GetSkillLevel();
            }

            int rating = (int)Math.Round(sumSkills / players.Count);
            return rating;
        }
    }
}
