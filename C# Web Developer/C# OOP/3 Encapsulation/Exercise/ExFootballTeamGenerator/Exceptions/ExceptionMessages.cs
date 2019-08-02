using System;
using System.Collections.Generic;
using System.Text;

namespace ExFootballTeamGenerator.Exceptions
{
    class ExceptionMessages
    {
        public static string nameInvalid = "A name should not be empty.";
        public static string statInvalid = "{0} should be between 0 and 100.";
        public static string removeMissingPlayer = "Player {0} is not in {1} team.";
        public static string addToMissingTeam = "Team {0} does not exist.";
        public static string showStatMissingTeam = "Team {0} does not exist.";


    }
}
