using System;
using System.Collections.Generic;
using System.Linq;

namespace ExAutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> carsToServe = new Queue<string>(cars);
            Stack<string> History = new Stack<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Service" && carsToServe.Count > 0)
                {
                    Console.WriteLine($"Vehicle {carsToServe.Peek()} got served.");
                    History.Push(carsToServe.Dequeue());
                }
                else if (command[0] =='C')
                {
                    string[] splitCommand = command.Split("-").ToArray();

                    if (carsToServe.Contains(splitCommand[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command=="History")
                {
                    Console.WriteLine(string.Join(", ",History));
                }
                command = Console.ReadLine();
            }
            if (carsToServe.Count>0)
            {
                Console.Write("Vehicles for service: ");
                Console.Write(string.Join(", ", carsToServe));
                Console.WriteLine();
            }
            Console.Write("Served vehicles: ");
            Console.Write(string.Join(", ", History));
            Console.WriteLine();



        }
    }
}
