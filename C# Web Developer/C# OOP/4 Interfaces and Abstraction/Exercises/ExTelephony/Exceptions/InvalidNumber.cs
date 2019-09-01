using System;
using System.Collections.Generic;
using System.Text;

namespace ExTelephony.Exceptions 
{
    class InvalidNumber : Exception
    {
        private const string EXC_MESSAGE = "Invalid number!";
        public InvalidNumber()
            :base(EXC_MESSAGE)
        {
        }

        public InvalidNumber(string message) : base(message)
        {
        }
    }
}
