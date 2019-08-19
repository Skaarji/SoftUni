using ExMillitaryElite.Enumerations;
using ExMillitaryElite.Exceptions;
using ExMillitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            ParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        private void ParseCorps(string corpsString)
        {
            Corps corps;

            bool parsed = Enum.TryParse<Corps>(corpsString, out corps);

            if (!parsed)
            {
                throw new InvalidCorpsException();
            }
            Corps = corps;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {Corps}";
        }
    }
}
