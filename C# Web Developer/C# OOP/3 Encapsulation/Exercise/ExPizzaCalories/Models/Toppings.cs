using System;
using System.Collections.Generic;
using System.Text;

namespace ExPizzaCalories
{
    public class Toppings
    {
        private string toppingType;
        private double weight;
        private double caloriesPerGram = 2;
        private double meatModifier = 1.2;
        private double veggiesModifier = 0.8;
        private double cheeseModifier = 1.1;
        private double sauceModifier = 0.9;
        

        public string ToppingType
        {
            get
            {
                return toppingType;
            }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value;
            }            
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value<1 || value>50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }
                weight = value;
            }            
        }

        public Toppings(string toppingType,double weight)
        {
            ToppingType = toppingType;
            Weight = weight;
        }

        public double ToppingCalories
        {
            get
            {
                double modifier = 0;
                switch (ToppingType.ToLower())
                {
                    case "meat":
                        modifier = meatModifier;
                        break;
                    case "veggies":
                        modifier = veggiesModifier;
                        break;
                    case "cheese":
                        modifier = cheeseModifier;
                        break;
                    case "sauce":
                        modifier = sauceModifier;
                        break;
                }
                return Weight * caloriesPerGram * modifier;


            }
        }
    }
}
