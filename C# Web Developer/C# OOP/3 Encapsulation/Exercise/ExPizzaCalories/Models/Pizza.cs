using System;
using System.Collections.Generic;
using System.Text;

namespace ExPizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private List<Toppings> toppings;
        private Dough dough;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (value.Length > 14 || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.InvalidNameForPizza);
                }
                name = value;
            }
        }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            toppings = new List<Toppings>();
            this.dough = dough;

        }

        public int NumberOfToppings
        {
            get
            {
                return this.toppings.Count;
            }
        }
        public double TotalCalories
        {
            get
            {
                if (toppings.Count >= 10)
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.InvalidToppingsCount);
                }
                return CalculateCalories();
            }
        }

        public void AddTopping(Toppings topping)
        {
            this.toppings.Add(topping);
        }
        private double CalculateCalories()
        {
            double topCalories = 0;
            foreach (var topping in toppings)
            {
                topCalories += topping.ToppingCalories;
            }
            double totalCalories = dough.DoughCalories + topCalories;
            return totalCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {TotalCalories:f2} Calories.";
        }
    }
}
