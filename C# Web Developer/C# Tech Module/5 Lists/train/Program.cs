using System;
using System.Collections.Generic;
using System.Linq;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassangers = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                if (command[0] == "Add")
                {
                    train.Add(int.Parse(command[1]));
                }
                else
                {
                    int addPassangers = int.Parse(command[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + addPassangers <= maxPassangers)
                        {
                            train[i] += addPassangers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in train)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
