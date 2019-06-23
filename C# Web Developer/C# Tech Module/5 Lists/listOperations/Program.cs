using System;
using System.Linq;
using System.Collections.Generic;

namespace listOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) >= list.Count || int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) >= list.Count || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            list.Add(list[0]);
                            list.RemoveAt(0);
                        }

                    }
                    else if (command[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            list.Insert(0, list[list.Count - 1]);
                            list.RemoveAt(list.Count - 1);

                        }
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
