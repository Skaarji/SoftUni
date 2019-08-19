using ExFoodShortage.Interfaces;
using ExFoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExFoodShortage
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            
            for (int n = 0; n < number; n++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                int age = int.Parse(command[1]);
                if (command.Length==4)
                {
                    IBuyer buyer = new Citizen(name,age,command[2],command[3]);
                    buyers.Add(buyer);
                }
                else if (command.Length==3)
                {
                    IBuyer buyer = new Rebel(name, age, command[2]);
                    buyers.Add(buyer);
                }
            }
            string names = Console.ReadLine();
            while (names!="End")
            {
                foreach (var item in buyers)
                {
                    if (item.Name==names)
                    {
                        item.BuyFood();
                    }
                }
                names = Console.ReadLine();
            }
            Console.WriteLine(buyers.Sum(x=>x.Food));
        }
    }
}
