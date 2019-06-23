using System;
using System.Collections.Generic;
using System.Linq;

namespace concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> bandsMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandsTimes = new Dictionary<string, int>();
            long totalTime = 0;

            while (command != "start of concert")
            {
                List<string> commandToString = command.Split("; ").ToList();

                if (commandToString[0] == "Add")
                {
                    List<string> members = commandToString[2].Split(", ").ToList();

                    if (!bandsMembers.ContainsKey(commandToString[1]))
                    {
                        bandsMembers.Add(commandToString[1], new List<string>());
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (!bandsMembers[commandToString[1]].Contains(members[i]))
                            {
                                bandsMembers[commandToString[1]].Add(members[i]);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (bandsMembers.ContainsKey(commandToString[1]))
                    {
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (!bandsMembers[commandToString[1]].Contains(members[i]))
                            {
                                bandsMembers[commandToString[1]].Add(members[i]);
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                }
                else if (commandToString[0] == "Play")
                {
                    int time = int.Parse(commandToString[2]);

                    if (!bandsTimes.ContainsKey(commandToString[1]))
                    {
                        bandsTimes.Add(commandToString[1], time);
                        totalTime += time;
                    }
                    else if (bandsTimes.ContainsKey(commandToString[1]))
                    {
                        bandsTimes[commandToString[1]] += time;
                        totalTime += time;
                    }

                }
                command = Console.ReadLine();
            }
            bandsTimes = bandsTimes.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            string bandName = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var item in bandsTimes)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine(bandName);
            foreach (var member in bandsMembers[bandName])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
