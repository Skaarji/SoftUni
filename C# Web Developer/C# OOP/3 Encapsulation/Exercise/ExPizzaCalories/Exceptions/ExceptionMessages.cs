using System;
using System.Collections.Generic;
using System.Text;

namespace ExPizzaCalories.Exceptions
{
   public  class ExceptionMessages
    {
        public static string InvalidDough = "Invalid type of dough.";
        public static string InvalidDoughWeight = "Dough weight should be in the range [1..200].";
        public static string InvalidNameForPizza = "Pizza name should be between 1 and 15 symbols.";
        public static string InvalidToppingsCount = "Number of toppings should be in range [0..10].";
    }
}
