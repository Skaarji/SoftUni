using ExMillitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Models
{
    public class Repair : IRepair
    {

        public Repair(string partName, int hoursWorked)
        {
            Part = partName;
            Hours = hoursWorked;
        }
        public string Part { get; private set; }

        public int Hours { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {Part} Hours Worked: {Hours}";
        }
    }
}
