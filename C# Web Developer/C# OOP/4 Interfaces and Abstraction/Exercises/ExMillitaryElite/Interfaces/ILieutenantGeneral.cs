using ExMillitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Interfaces
{
    public interface ILieutenantGeneral : ISoldier
    {
        IReadOnlyCollection<ISoldier> Privates { get; }

        void AddPrivate(ISoldier @private);
    }
}
