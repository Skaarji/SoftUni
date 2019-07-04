using System;
using System.Collections.Generic;
using System.Linq;

namespace ExCupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(bottlesArr); 
            Stack<int> cupss = new Stack<int>(cupsArr.Reverse());
            int wastedWater = 0;
            int currentCup = cupss.Peek();
            int currentBottle = bottles.Peek();

            while (bottles.Count > 0  && cupss.Count>0)
            {
                currentCup = cupss.Peek();
                currentBottle = bottles.Peek();

                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                    cupss.Pop();
                    bottles.Pop();
                    continue;
                }
                else if (currentBottle< currentCup)
                {
                    currentCup -= currentBottle;
                    bottles.Pop();
                    cupss.Pop();
                    cupss.Push(currentCup);                    
                    continue;
                }
            }
            if (bottles.Count >0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (cupss.Count >0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupss)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");

            }

        }
    }
}
