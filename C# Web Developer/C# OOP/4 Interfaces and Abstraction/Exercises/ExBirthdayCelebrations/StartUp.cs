using ExBirthdayCelebrations.Interfaces;
using ExBirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExBirthdayCelebrations
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            List<IBirthday> birthdays = new List<IBirthday>();

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] cmdn = command.Split().ToArray();

                if (cmdn[0]=="Pet")
                {
                    IBirthday pet = new Pet(cmdn[1], cmdn[2]);
                    birthdays.Add(pet);
                }
                else if (cmdn[0]=="Citizen")
                {
                    string name = cmdn[1];
                    int age = int.Parse(cmdn[2]);
                    string id = cmdn[3];
                    string birthday = cmdn[4];

                    IBirthday citizen = new Citizen(name, age, id, birthday);
                    birthdays.Add(citizen);
                }
                command = Console.ReadLine();
            }
            string year = Console.ReadLine();

            
            foreach (var item in birthdays)
            {
                if (item.Birthday.EndsWith(year))
                {
                    Console.WriteLine(item.Birthday);
                }                
            }
        }
    }
}
