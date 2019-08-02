using ExFootballTeamGenerator.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExFootballTeamGenerator.Model
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int driblle;
        private int passing;
        private int shooting;
        
        

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
        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                if (value <0 || value >100)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.statInvalid, nameof(Endurance)));
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                if (value <0 || value >100)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.statInvalid, nameof(Sprint)));
                }
                sprint = value;
            }
        }
        public int Driblle
        {
            get
            {
                return this.driblle;
            }
            private set
            {
                if (value <0 || value >100)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.statInvalid, nameof(Driblle)));
                }
                driblle = value;
            }
        }
        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                if (value <0 || value >100)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.statInvalid, nameof(Passing)));
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                if (value <0 || value >100)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.statInvalid, nameof(Shooting)));
                }
                shooting = value;
            }
        }

        public Player(string name, int endurance, int sprint, int driblle, int passing,int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Driblle = driblle;
            Passing = passing;
            Shooting = shooting;                       
        }
        
        public double GetSkillLevel()
        {
            double skillLevel = (Endurance + Sprint + Driblle + Passing + Shooting) / 5.0;
            return skillLevel;
        }
    }
}
