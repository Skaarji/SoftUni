using System;
using System.Collections.Generic;
using System.Linq;
using ExShoppingSpree.Model;

namespace ExShoppingSpree
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            try
            {
            string[] ppl = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            for (int i = 0; i < ppl.Length; i++)
            {
                string[] tokens = ppl[i].Split('=');
                string name = tokens[0];
                decimal money = decimal.Parse(tokens[1]);
                Person person = new Person(name, money);
                people.Add(person);
            }
            string[] prod = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < prod.Length; i++)
            {
                string[] tokens = prod[i].Split('=');
                string name = tokens[0];
                decimal cost = decimal.Parse(tokens[1]);
                Product product = new Product(name, cost);
                products.Add(product);
            }

            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] tokens = input.Split();
                string personName = tokens[0];
                string productName = tokens[1];
                foreach (var person in people)
                {
                    if (person.Name==personName)
                    {
                        foreach (var product in products)
                        {
                            if (product.Name==productName)
                            {
                                person.BuyProduct(product);
                                    break;
                            }
                        }
                    }
                }
                input = Console.ReadLine(); 
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }



        }
    }
}
