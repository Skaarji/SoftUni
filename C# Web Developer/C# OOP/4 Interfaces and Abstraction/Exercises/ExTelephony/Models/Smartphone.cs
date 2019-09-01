using ExTelephony.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExTelephony.Exceptions;

namespace ExTelephony.Models 
{
    public class Smartphone : IBrowse, ICall
    {
        public Smartphone()
        {

        }

        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new InvalidURL();
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(c=> char.IsDigit(c)))
            {
                throw new InvalidNumber();
            }
            return $"Calling... {phoneNumber}";
        }
    }
}
