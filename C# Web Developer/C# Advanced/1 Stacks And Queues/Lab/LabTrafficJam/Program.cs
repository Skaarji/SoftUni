using System;
using System.Collections.Generic;

namespace LabTrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int canPass = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;
            while (input != "end")
            {
                if (input =="green")
                {
                    int counter = 0;
                    while (cars.Count >0 && counter < canPass)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                        totalCarsPassed++;
                    }
                    counter = 0;                    
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
