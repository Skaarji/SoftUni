using System;
using System.Collections.Generic;

namespace LabHotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int toss = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(names);

            while (kids.Count > 1)
            {
                for (int i = 0; i < toss -1; i++)
                {
                    string currentkid = kids.Dequeue();
                    kids.Enqueue(currentkid);
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Peek()}");

        }
    }
}
