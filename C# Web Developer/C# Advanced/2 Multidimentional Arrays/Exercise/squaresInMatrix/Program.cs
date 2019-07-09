using System;
using System.Linq;

namespace squaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (dimentions.Length<2)
            {
                Console.WriteLine(0);
                return;
            }
            char[,] array = new char[dimentions[0], dimentions[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = input[j];
                }
            }            
            int squares = 0;
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {

                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] == array[i, j + 1]
                     && array[i + 1, j] == array[i + 1,j + 1]
                     && array[i, j] == array[i + 1, j])
                    {
                        squares++;
                    }

                }
            }
            Console.WriteLine(squares);

        }
    }
}
