using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Interfaces
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
