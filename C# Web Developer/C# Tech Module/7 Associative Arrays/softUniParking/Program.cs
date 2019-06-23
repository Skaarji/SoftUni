using System;
using System.Collections.Generic;
using System.Linq;

namespace softUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var register = new Dictionary<string, string>() ;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0]== "register")
                {
                    if (register.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[command[1]]}");
                    }
                    else if (!register.ContainsKey(command[1]))
                    {
                        register.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0]== "unregister")
                {
                    if(register.ContainsKey(command[1]))
                    {
                        register.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else if (!register.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
