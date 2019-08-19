using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Exceptions
{
    public class InvalidStateException : Exception
    {
        private const string EX_MES = "Invalid state!";
        public InvalidStateException()
            :base(EX_MES)
        {
        }

        public InvalidStateException(string message) : base(message)
        {
        }
    }
}
