using ExBorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExBorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Entity> entities = new List<Entity>();
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] commandTokens = command.Split().ToArray();
                if (commandTokens.Length == 2)
                {
                    string model = commandTokens[0];
                    string id = commandTokens[1];
                    Entity entity = new Robot(model, id);
                    entities.Add(entity);
                }
                else if (commandTokens.Length==3)
                {
                    string name = commandTokens[0];
                    int age = int.Parse(commandTokens[1]);
                    string id = commandTokens[2];
                    Entity entity = new Citizen(name, age, id);
                    entities.Add(entity);
                }
                command = Console.ReadLine();
            }
            string validID = Console.ReadLine();

            entities = entities.Where(x => x.Id.EndsWith(validID)).ToList();

            foreach (var item in entities)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
