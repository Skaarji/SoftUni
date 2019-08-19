using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Interfaces
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
