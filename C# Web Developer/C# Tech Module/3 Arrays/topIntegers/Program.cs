﻿using System;
using System.Linq;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            

            for (int i = 0; i < array.Length; i++)
            {
                Boolean isBigger = true;
                for (int j = i+1; j < array.Length; j++)
                {

                    if (array[i] <= array[j])
                    {
                        isBigger = false;
                        break;
                    }
                    

                }
                if (isBigger == true)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
