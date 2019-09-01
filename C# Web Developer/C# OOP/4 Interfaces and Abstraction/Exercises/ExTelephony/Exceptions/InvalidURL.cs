using System;
using System.Collections.Generic;
using System.Text;

namespace ExTelephony.Exceptions
{
    class InvalidURL : Exception
    {

        private const string EXC_MESSAGE = "Invalid URL!";
        public InvalidURL()
            : base(EXC_MESSAGE)
        {
        }

        public InvalidURL(string message)
            : base(message)
        {
        }
    }
}
