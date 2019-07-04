using System;
using System.Collections.Generic;
using System.Linq;

namespace ExFashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCount = 1;
            int CurrentRack = 0;

            while (stack.Count>0)
            {                
                if ((CurrentRack + stack.Peek()) > rackCapacity)
                {
                    rackCount++;
                    CurrentRack = 0;
                    continue;
                }
                else if ((CurrentRack + stack.Peek()) <= rackCapacity)
                {
                    CurrentRack+=stack.Pop();
                }
            }
            Console.WriteLine(rackCount);

            
        }
    }
}
