using System;
using System.Linq;

namespace snakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            string snake = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)

            {
                for (int j = 0; j < matrix.GetLength(1) ; j++)
                {
                    if (counter >= snake.Length)
                    {
                        counter = 0;
                    }
                    matrix[i, j] = snake[counter++];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }





        }
    }
}
