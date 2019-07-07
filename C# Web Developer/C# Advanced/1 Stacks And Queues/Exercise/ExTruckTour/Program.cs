using System;
using System.Collections.Generic;
using System.Linq;

namespace ExTruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());


            int currentIndexStart = 0;

            Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }
            while (true)
            {
                long fuelInTank = 0;
                foreach (var pump in pumps)
                {
                    long[] currentPump = pump.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                    fuelInTank += currentPump[0] - currentPump[1];

                    if (fuelInTank < 0)
                    {
                        currentIndexStart++;
                        pumps.Enqueue(pumps.Dequeue());
                        break;
                    }
                }
                if (fuelInTank >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(currentIndexStart);
        }
    }
}
