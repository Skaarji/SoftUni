using ExFoodShortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExFoodShortage.Models
{
    public class Pet : IBirthday

    {
        public string Name { get; private set; }
        public string Birthday { get; private set; }

        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
