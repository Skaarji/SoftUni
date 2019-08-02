using ExPizzaCalories.Models;
using System;

namespace ExPizzaCalories
{
   public  class StartUp

    {
        static void Main(string[] args)
        {
            try
            {
            string[] nameToken = Console.ReadLine().Split();
            string[] doughToken = Console.ReadLine().Split();
            Dough dough = new Dough(doughToken[1], doughToken[2], double.Parse(doughToken[3]));
            Pizza pizza = new Pizza(nameToken[1],dough);
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] tokens = input.Split();
                Toppings topping = new Toppings(tokens[1], double.Parse(tokens[2]));
                pizza.AddTopping(topping);
                input = Console.ReadLine();
            }
            Console.WriteLine(pizza);

            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
