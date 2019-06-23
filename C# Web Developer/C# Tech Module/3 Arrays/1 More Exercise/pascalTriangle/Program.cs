using System;

namespace pascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[] previousArray = new int[numberOfRows];
            previousArray[0] = 1;
            Console.WriteLine(previousArray[0]);

            for (int i = 2; i <= numberOfRows; i++)
            {
                int[] currentArray =new int[i];
                for (int j = 0; j < currentArray.Length; j++)
                {
                    if (j - 1 < 0)
                    {
                        currentArray[j] = 1;
                    }                    
                    else
                    {
                        currentArray[j] = previousArray[j] + previousArray[j - 1];
                    }
                }
                Console.WriteLine(String.Join(" ", currentArray));
                for (int k = 0; k < currentArray.Length; k++)
                {
                    previousArray[k] = currentArray[k];
                }

            }
            //int c = 1;

            //for (int i = 0; i < numberOfRows; i++)
            //{
                
            //    for (int j = 0; j <= i; j++)
            //    {
            //        if (j == 0 || i == 0)
            //        {
            //            c = 1;
            //        }

            //        else
            //        {
            //            c = c * (i - j + 1) / j;
            //        }
            //        Console.Write($"{c} ");
            //    }
            //    Console.Write("\n");

            //}
        }
    }
}
