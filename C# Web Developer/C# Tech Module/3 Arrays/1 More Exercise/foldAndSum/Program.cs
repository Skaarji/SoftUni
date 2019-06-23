using System;
using System.Linq;


namespace foldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] leftRightArray = new int[array.Length / 2];
            int[] centerArray = new int[array.Length / 2];
            for (int i = 0; i < array.Length/4; i++)
            {
                leftRightArray[i] = array[(array.Length/4)-1-i];
            }            
            for (int i = 0; i < array.Length/4; i++)
            {
                leftRightArray[(leftRightArray.Length / 2) + i] = array[array.Length-1- i];
            }            
            for (int i = 0; i < centerArray.Length; i++)
            {
                centerArray[i] = array[(array.Length / 4) + i];
            }            
            for (int i = 0; i < centerArray.Length; i++)
            {
                Console.Write($"{centerArray[i] + leftRightArray[i]} "); 
            }

        }
    }
}
