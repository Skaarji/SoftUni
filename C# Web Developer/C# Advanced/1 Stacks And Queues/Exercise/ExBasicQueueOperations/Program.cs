using System;
using System.Collections.Generic;
using System.Linq;

namespace ExBasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersToEnqueue = numbers[0];
            int numbersToDequeue = numbers[1];
            int numberToLookFor = numbers[2];
            if (numbersToDequeue == numbersToEnqueue)
            {
                Console.WriteLine(0);
                return;
            }

            int[] forQueue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(forQueue);

            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(numberToLookFor)==true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }

        }
    }
}
