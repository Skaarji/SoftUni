using System;
using System.Collections.Generic;
using System.Text;

namespace ExPizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double whiteModifier = 1.5;
        private double wholegrainModifier = 1.0;
        private double crispyModifier = 0.9;
        private double chewyModifier = 1.1;
        private double homemadeModifier = 1.0;
        private double caloriesPerGram = 2;

        public string FlourType
        {
            get
            {
                return flourType;
            }
            private set
            {
                if (value.ToLower()!="white" && value.ToLower()!= "wholegrain")
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.InvalidDough);
                }
                flourType = value;
            }
        }
        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.InvalidDough);
                }
                bakingTechnique = value;
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
                if (value<1 || value>200)
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.InvalidDoughWeight);
                }
                weight = value;
            }
        }
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public double DoughCalories
        {
            get
            {
                return GetCalories();
            }
        }
        private double GetCalories()
        {
            double flourModifier = 0;
            if (FlourType.ToLower()=="white")
            {
                flourModifier = whiteModifier;
            }
            else
            {
                flourModifier = wholegrainModifier;
            }
            double bakingModifier = 0;
            switch (BakingTechnique.ToLower())
            {
                case "crispy":
                    bakingModifier = crispyModifier;
                    break;
                case "chewy":
                    bakingModifier = chewyModifier;
                    break;
                case "homemade":
                    bakingModifier = homemadeModifier;
                    break;
            }
            double calories = Weight * caloriesPerGram * flourModifier * bakingModifier;
            return calories;
        }
    }
}
