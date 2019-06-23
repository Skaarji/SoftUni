using System;
using System.Collections.Generic;
using System.Linq;

namespace forceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> jediList = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                string[] command = input.Split(" | ").ToArray();
                if (command.Length == 2)
                {
                    if (!jediList.ContainsKey(command[0]))
                    {
                        jediList.Add(command[0], new List<string>());
                        bool containsStudent = CheckIfStudentExists(jediList, command);

                        if (containsStudent == false)
                        {
                            jediList[command[0]].Add(command[1]);
                        }

                    }
                    else if (jediList.ContainsKey(command[0]))
                    {
                        bool containsStudent = CheckIfStudentExists(jediList, command);

                        if (containsStudent == false)
                        {
                            jediList[command[0]].Add(command[1]);
                        }

                    }
                }
                else if (command.Length == 1)
                {
                    command = input.Split(" -> ").ToArray();

                    if (!jediList.ContainsKey(command[1]))
                    {
                        jediList.Add(command[1], new List<string>());
                    }

                    if (!jediList[command[1]].Contains(command[0]))
                    {
                        bool containsStudent = false;
                        foreach (var students in jediList)
                        {
                            if (students.Value.Contains(command[0]))
                            {
                                containsStudent=true;
                            }
                        }
                        if (containsStudent == true)
                        {
                            foreach (var item in jediList)
                            {
                                if (item.Value.Contains(command[0]))
                                {
                                    int index = item.Value.IndexOf(command[0]);
                                    item.Value.RemoveAt(index);
                                }
                            }
                        }

                        jediList[command[1]].Add(command[0]);
                        Console.WriteLine($"{command[0]} joins the {command[1]} side!");
                    }
                }
                input = Console.ReadLine();
            }
            jediList = jediList.Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in jediList)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                
                foreach (var students in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {students}");
                }
            }

        }

        private static bool CheckIfStudentExists(Dictionary<string, List<string>> jediList, string[] command)
        {
            foreach (var students in jediList)
            {
                if (students.Value.Contains(command[1]))
                {
                    return true;
                }
            }

            return false;

        }
    }
}
