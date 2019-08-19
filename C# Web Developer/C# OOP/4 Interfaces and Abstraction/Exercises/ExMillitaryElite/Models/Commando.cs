using ExMillitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {

        private readonly List<IMission> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => this.missions;

        public void AddMission(IMission mission)
        {
            missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Mission:");

            foreach (var mission in missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
