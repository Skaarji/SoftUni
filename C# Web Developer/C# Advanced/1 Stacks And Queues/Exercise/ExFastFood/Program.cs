using System;
using System.Collections.Generic;
using System.Linq;

namespace ExFastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] numberSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(numberSequence);

            Console.WriteLine(orders.Max());

            for (int i = 0; i < orders.Count; i++)
            {
                if (foodQuantity>= orders.Peek())
                {
                    foodQuantity -= orders.Dequeue();
                    i--;
                    continue;
                }
                else if (foodQuantity< orders.Peek())
                {
                    break;
                }
            }
            if (orders.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else if (orders.Count>0)
            {
                Console.Write("Orders left: ");
                while (orders.Count>0)
                {
                    Console.Write($"{orders.Dequeue()} ");
                }
            }

        }
    }
}
