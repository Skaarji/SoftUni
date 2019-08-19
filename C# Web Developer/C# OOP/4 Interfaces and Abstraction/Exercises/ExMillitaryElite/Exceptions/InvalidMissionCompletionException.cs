using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Exceptions
{
    public class InvalidMissionCompletionException : Exception
    {
        private const string EX_MES = "Mission Already finished!";
        public InvalidMissionCompletionException()
            :base(EX_MES)
        {
        }

        public InvalidMissionCompletionException(string message) : base(message)
        {
        }
    }
}
