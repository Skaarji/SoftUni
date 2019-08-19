using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string EX_MES = "Invalid corps!";
        public InvalidCorpsException()
            :base(EX_MES)
        {
        }

        public InvalidCorpsException(string message) : base(message)
        {
        }
    }
}
