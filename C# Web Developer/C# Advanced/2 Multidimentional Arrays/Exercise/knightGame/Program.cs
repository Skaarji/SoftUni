using System;

namespace knightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            char[,] board = new char[dimensions, dimensions];
            for (int i = 0; i < dimensions; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < dimensions; j++)
                {
                    board[i, j] = input[j];
                }
            }

            int counter = 0; 


            while (true)
            {
                int maxCount = 0;
                
                int knightRow = 0;
                int knightCol = 0;


                for (int i = 0; i < dimensions; i++)
                {
                    for (int j = 0; j < dimensions; j++)
                    {
                        int knightsCount = 0;
                        if (board[i, j] == 'K')
                        {
                            if (IsInside(board, i - 2, j + 1) && board[i - 2, j + 1] == 'K')
                            {
                                knightsCount++;
                            } 
                            if (IsInside(board, i - 2, j - 1) && board[i - 2, j - 1] == 'K')
                            {
                                knightsCount++;
                            }
                            if (IsInside(board, i + 2, j + 1) && board[i + 2, j + 1] == 'K')
                            {
                                knightsCount++;
                            }
                            if (IsInside(board, i + 2, j - 1) && board[i + 2, j - 1] == 'K')
                            {
                                knightsCount++;
                            }
                            if (IsInside(board, i - 1, j - 2) && board[i - 1, j - 2] == 'K')
                            {
                                knightsCount++;
                            }
                            if (IsInside(board, i + 1, j - 2) && board[i + 1, j - 2] == 'K')
                            {
                                knightsCount++;
                            }
                            if (IsInside(board, i + 1, j + 2) && board[i + 1, j + 2] == 'K')
                            {
                                knightsCount++;
                            }
                            if (IsInside(board, i - 1, j + 2) && board[i - 1, j + 2] == 'K')
                            {
                                knightsCount++;
                            }
                        }
                        if (knightsCount >maxCount)
                        {
                            maxCount = knightsCount;
                            knightCol = j;
                            knightRow = i;
                        }
                    }
                }

                if (maxCount==0)
                {
                    break;
                }
                else
                {
                    board[knightRow, knightCol] = '0';
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }

        private static bool IsInside(char[,] board, int row, int col)
        {
            return row < board.GetLength(0) && row >= 0 &&
                 col < board.GetLength(1) && col >= 0;
        }
    }
}
