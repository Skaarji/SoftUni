using System;
using System.Collections.Generic;
using System.Linq;

namespace LabPrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(array);
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                int number = queue.Peek();
                if (number % 2 == 0)
                {
                    queue.Dequeue();
                    queue.Enqueue(number);
                }
                else
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
