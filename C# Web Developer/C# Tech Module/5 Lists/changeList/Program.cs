using System;
using System.Linq;
using System.Collections.Generic;

namespace changeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Delete")
                {
                    while (list.Remove(int.Parse(command[1])) == true)
                    {
                        list.Remove(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
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
