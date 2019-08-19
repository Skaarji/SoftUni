using ExFoodShortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExFoodShortage.Models
{
    public class Citizen : Entity, IBirthday, IBuyer

    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Birthday { get; private set; }

        public int Food { get; private set; }

        

        public Citizen(string name, int age,string id,string birthday)
            : base(id)
        {
            Food = 0;
            Name = name;
            Age = age;
            Birthday = birthday;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
