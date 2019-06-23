using System;
using System.Collections.Generic;
using System.Linq;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var products = new Dictionary<string, List<double>>();

            while (input != "buy")
            {
                string[] command = input.Split().ToArray();

                if (!products.ContainsKey(command[0]))
                {
                    products.Add(command[0], new List<double>());
                    
                    products[command[0]].Add(double.Parse(command[1]));
                    products[command[0]].Add(double.Parse(command[2]));
                    
                }

                else if (products.ContainsKey(command[0]))
                {
                    products[command[0]][0] =double.Parse(command[1]);
                    products[command[0]][1] +=double.Parse(command[2]);
                }

                input = Console.ReadLine();

            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }
        }
    }
}
