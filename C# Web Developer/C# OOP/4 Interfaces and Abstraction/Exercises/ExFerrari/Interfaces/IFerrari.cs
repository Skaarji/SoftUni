using System;
using System.Collections.Generic;
using System.Text;

namespace ExFerrari.Interfaces
{
    public interface IFerrari
    {
        string Driver { get; }

        string Gas();
        string Breaks();


    }
}
