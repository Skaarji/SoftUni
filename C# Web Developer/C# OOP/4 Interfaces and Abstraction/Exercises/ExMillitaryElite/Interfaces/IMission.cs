using ExMillitaryElite.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
