using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());
            int[,] array = new int[dimentions, dimentions];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = input[j];
                }
            }
            int diag1 = 0;
            int diag2 = 0;
            for (int i = 0; i < dimentions; i++)
            {
                diag1 += array[i, i];
                diag2 += array[i, dimentions - 1 - i];
            }

            Console.WriteLine(Math.Abs(diag1 - diag2));
        }
    }
}
