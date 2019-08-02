using System;
using System.Collections.Generic;
using System.Text;

namespace ExShoppingSpree.Model
{
    public class Person
    {

        private string name;
        private decimal money;
        private List<string> bagOfProducts;

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
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value <0)
                {
                    throw new ArgumentException(Exceptions.ExceptionMessages.MoneyException);
                }
                money = value;
            }
        }

        public Person(string name,decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<string>();
        }

  
        public void BuyProduct(Product product)
        {
            decimal itemCost = product.Cost;
            if (this.Money - itemCost<0)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} bought {product.Name}");
                Money -= itemCost;
                bagOfProducts.Add(product.Name);
            }
        }

        public override string ToString()
        {
            if (bagOfProducts.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {String.Join(", ", bagOfProducts)}";
            }
        }

    }
}
