using ExMillitaryElite.Exceptions;
using ExMillitaryElite.Interfaces;
using ExMillitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExMillitaryElite.Core
{
    public class Engine

    {

        private readonly List<ISoldier> army;
        public Engine()
        {
            army = new List<ISoldier>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split().ToArray();

                string type = tokens[0];
                string id = tokens[1];
                string firstName = tokens[2];
                string lastName = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);



                if (type == "Private")
                {
                    Private soldier = new Private(id, firstName, lastName, salary);
                    army.Add(soldier);

                }
                else if (type == "LieutenantGeneral")
                {
                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);
                    string[] soldierTokens = tokens.Skip(5).ToArray();

                    foreach (var pid in soldierTokens)
                    {
                        ISoldier soldierToAdd = army.First(x => x.Id == pid);
                        general.AddPrivate(soldierToAdd);
                    }
                    army.Add(general);
                }
                else if (type == "Engineer")
                {
                    try
                    {
                        string corps = tokens[5];

                        IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                        string[] repairTokens = tokens.Skip(6).ToArray();

                        AddRepairs(engineer, repairTokens);
                        army.Add(engineer);

                    }
                    catch (InvalidCorpsException)
                    {

                        
                    }
                }
                else if (type=="Commando")
                {
                    try
                    {
                        string corps = tokens[5];

                        ICommando commando = new Commando(id,firstName, lastName, salary, corps);
                        string[] missionTokens = tokens.Skip(6).ToArray();

                        for (int i = 0; i < missionTokens.Length; i+=2)
                        {
                            try
                            {
                                string codename = missionTokens[i];
                                string state = missionTokens[i + 1];
                                IMission mission = new Mission(codename, state);
                                commando.AddMission(mission);

                            }
                            catch (InvalidStateException)
                            {
                                continue;                                
                            }                           

                        }
                        army.Add(commando);

                    }
                    catch (InvalidCorpsException)
                    {

                        
                    }
                }
                else if (type=="Spy")
                {
                    int codeNumber = (int)salary;
                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                    army.Add(spy);
                }

                command = Console.ReadLine();
            }
            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (var sold in this.army)
            {
                Type type = sold.GetType();

                Object actual = Convert.ChangeType(sold, type);

                Console.WriteLine(actual.ToString());
            }
        }

        private static void AddRepairs(IEngineer engineer, string[] repairTokens)
        {
            for (int i = 0; i < repairTokens.Length; i += 2)
            {
                string partName = repairTokens[i];
                int hours = int.Parse(repairTokens[i + 1]);

                IRepair repair = new Repair(partName, hours);
                engineer.AddRepair(repair);
            }
        }
    }
}
