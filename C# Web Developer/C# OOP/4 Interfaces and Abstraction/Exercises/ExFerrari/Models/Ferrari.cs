using ExFerrari.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExFerrari.Models
{
    public class Ferrari :IFerrari
    {
        private readonly string Model = "488-Spider";

        public string Driver { get; private set; }
        public Ferrari(string driver)
        {            
            Driver = driver;            
        }

        public string Breaks()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Breaks()}/{this.Gas()}/{this.Driver}";
        }
    }
}
