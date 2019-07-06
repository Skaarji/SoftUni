using System;
using System.Collections.Generic;
using System.Linq;

namespace ExKeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int priceIntel = int.Parse(Console.ReadLine());

            Stack<int> locks = new Stack<int>(locksArray.Reverse());
            Stack<int> bullets = new Stack<int>(bulletsArray);
            Queue<int> barrel = new Queue<int>();
            for (int i = 0; i < sizeGunBarrel; i++)
            {
                if (bullets.Count>0)
                {
                    barrel.Enqueue(bullets.Pop());
                }                
            }

            while (locks.Count>0 && priceIntel >0 && barrel.Count>0)
            {
                int currentBullet = barrel.Peek();
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    barrel.Dequeue();
                    locks.Pop();
                    priceIntel -= bulletPrice;
                    Console.WriteLine("Bang!");
                    Reloading(sizeGunBarrel, bullets, barrel);
                }
                else if (currentBullet > currentLock)
                {
                    barrel.Dequeue();
                    priceIntel -= bulletPrice;
                    Console.WriteLine("Ping!");
                    Reloading(sizeGunBarrel, bullets, barrel);

                }

            }
            if (locks.Count == 0)
            {
                Console.WriteLine($"{barrel.Count + bullets.Count} bullets left. Earned ${priceIntel}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }


        }

        private static void Reloading(int sizeGunBarrel, Stack<int> bullets, Queue<int> barrel)
        {
            if (barrel.Count == 0 && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
                for (int i = 0; i < sizeGunBarrel; i++)
                {
                    if (bullets.Count > 0)
                    {
                        barrel.Enqueue(bullets.Pop());
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
