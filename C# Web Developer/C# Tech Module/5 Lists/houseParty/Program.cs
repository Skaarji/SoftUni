using System;
using System.Linq;
using System.Collections.Generic;

namespace houseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> listOfNames = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[2] == "going!")
                {
                    if (listOfNames.Contains(command[0]) == true)
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else if (listOfNames.Contains(command[0]) == false)
                    {
                        listOfNames.Add(command[0]);
                    }
                }
                else if (command[2] == "not")
                {
                    if (listOfNames.Contains(command[0]) == false)
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                    else if (listOfNames.Contains(command[0]) == true)
                    {
                        listOfNames.Remove(command[0]);
                    }
                }
            }
            foreach (var item in listOfNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
