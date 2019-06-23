using System;
using System.Linq;

namespace equalSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int counter = 0;
            //for (int i = 1; i < array.Length - 1; i++)
            //{
            //    int sumleft = 0;
            //    int sumright = 0;
            //    int[] left = new int[i - 1];
            //    for (int j = 0; j < left.Length; j++)
            //    {
            //        left[j] = array[i+j];
            //        sumleft += left[j];
            //    }
            //    int[] right = new int[array.Length - i];
            //    for (int k = 0; k < right.Length; k++)
            //    {
            //        right[k] = array[array.Length - k - 1 ];
            //        sumright += right[k];
            //    }
            //    if (array[i] == sumleft && array[i] == sumright)
            //    {
            //        counter++;
            //    }
            //}
            //if (counter == 0)
            //{
            //    Console.WriteLine("no");
            //}
            //else if (counter != 0)
            //{
            //    Console.WriteLine(counter);
            //}
            int sumRight = 0;
            int sumLeft = 0;
            int counter = 0;
            

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                for (int k = 0; k < i; k++)
                {
                    sumLeft += array[k];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    sumRight = 0;
                    sumLeft = 0;
                    counter++;
                }
                else if (sumRight == 0 && sumLeft ==0)
                {
                    Console.WriteLine(0);
                    counter++;
                }
                else
                {
                    sumRight = 0;
                    sumLeft = 0;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("no");
            }

            


        }
    }
}
