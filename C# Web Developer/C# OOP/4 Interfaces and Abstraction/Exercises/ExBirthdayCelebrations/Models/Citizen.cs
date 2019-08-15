using ExBirthdayCelebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExBirthdayCelebrations.Models
{
    public class Citizen : Entity, IBirthday

    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Birthday { get; private set; }

        public Citizen(string name, int age,string id,string birthday)
            : base(id)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
        }
    }
}
