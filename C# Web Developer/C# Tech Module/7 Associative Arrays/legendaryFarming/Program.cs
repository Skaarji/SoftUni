using System;
using System.Collections.Generic;
using System.Linq;

namespace legendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junk = new Dictionary<string, int>();
            Dictionary<string, int> mats = new Dictionary<string, int>
            {
                { "shards", 0},
                { "motes", 0},
                { "fragments", 0}
            };
            int Shadowmourne = 0;
            int Valanyr = 0;
            int Dragonwrath = 0;

            while (Dragonwrath < 250 && Shadowmourne < 250 && Valanyr < 250)
            {
                string[] input = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
                for (int i = 1; i < input.Length; i += 2)
                {
                    if (input[i] == "shards" || input[i] == "motes" || input[i] == "fragments")
                    {
                        mats[input[i]] += int.Parse(input[i - 1]);
                        switch (input[i].ToString())
                        {
                            case "shards":
                                Shadowmourne += int.Parse(input[i - 1]);
                                break;
                            case "fragments":
                                Valanyr += int.Parse(input[i - 1]);
                                break;
                            case "motes":
                                Dragonwrath += int.Parse(input[i - 1]);
                                break;
                            default:
                                break;
                        }
                        if (Dragonwrath >= 250 || Shadowmourne >= 250 || Valanyr >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(input[i]))
                        {
                            junk[input[i]] += int.Parse(input[i - 1]);
                        }
                        else if (!junk.ContainsKey(input[i]))
                        {
                            junk.Add(input[i], int.Parse(input[i - 1]));
                        }
                    }
                }
            }
            if (Shadowmourne >= 250)
            {
                Console.WriteLine($"Shadowmourne obtained!");
                mats["shards"] -= 250;
            }
            else if (Dragonwrath >= 250)
            {
                Console.WriteLine($"Dragonwrath obtained!");
                mats["motes"] -= 250;
            }
            else if (Valanyr >= 250)
            {
                Console.WriteLine($"Valanyr obtained!");
                mats["fragments"] -= 250;
            }


            foreach (var item in mats.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
