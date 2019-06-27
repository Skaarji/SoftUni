using System;
using System.Collections.Generic;
using System.Linq;

namespace LabStackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbs = new Stack<int>(numbers);

            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0]=="add")
                {
                    numbs.Push(int.Parse(command[1]));
                    numbs.Push(int.Parse(command[2]));
                }
                else if (command[0]=="remove")
                {
                    if (numbs.Count < int.Parse(command[1]))
                    {
                        input = Console.ReadLine().ToLower();
                        continue;
                    }
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        numbs.Pop();
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine(numbs.Sum());
        }
    }
}
