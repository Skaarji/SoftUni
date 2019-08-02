using System;
using System.Collections.Generic;
using System.Text;

namespace ExShoppingSpree.Model
{
   public  class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.NameException);
                }
                name = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.MoneyException);
                }
                cost = value;
            }
        }

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }



        
        


    }
}
