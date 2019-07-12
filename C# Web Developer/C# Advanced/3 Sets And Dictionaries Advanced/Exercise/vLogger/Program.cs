using System;
using System.Collections.Generic;
using System.Linq;

namespace vLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (input != "Statistics")
            {
                string[] command = input.Split();

                if (command[1] == "joined" && !vloggers.ContainsKey(command[0]))
                {
                    vloggers.Add(command[0], new Dictionary<string, HashSet<string>>());
                    vloggers[command[0]].Add("followers", new HashSet<string>());
                    vloggers[command[0]].Add("following", new HashSet<string>());
                }
                else if (command[1] == "followed" && vloggers.ContainsKey(command[0]) && vloggers.ContainsKey(command[2]) && command[0] != command[2])
                {
                    vloggers[command[0]]["following"].Add(command[2]);
                    vloggers[command[2]]["followers"].Add(command[0]);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int rank = 1;

            foreach (var item in vloggers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x=>x.Value["following"].Count))
            {
                Console.WriteLine($"{rank}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");

                if (rank==1)
                {
                    foreach (var fol in item.Value["followers"].OrderBy(x => x)) 
                    {
                        Console.WriteLine($"*  {fol}");
                    }
                }
                rank++;
            }

        }
    }
}
