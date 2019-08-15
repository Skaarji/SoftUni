using System;
using System.Collections.Generic;
using System.Text;

namespace ExBorderControl.Models
{
    public class Citizen : Entity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Citizen(string name, int age,string id)
            : base(id)
        {
            Name = name;
            Age = age;
        }
    }
}
