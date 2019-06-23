using System;
using System.Linq;

namespace ladybug
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            string[] initialLadyBugs = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < initialLadyBugs.Length; i++)
            {
                int currentIndex = int.Parse(initialLadyBugs[i]);

                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    field[currentIndex] = 1;
                }
            }
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while (input[0] != "end")
            {

                long ladybugToMoveIndex = long.Parse(input[0]);
                long distanceToMove = long.Parse(input[2]);
                string directionToMove = input[1];

                if (ladybugToMoveIndex < 0 || ladybugToMoveIndex >= field.Length || field[ladybugToMoveIndex] == 0)
                {
                    input = Console.ReadLine().Split();
                    continue;
                }
                else
                {
                    if (directionToMove == "right")
                    {

                        if (distanceToMove > 0)
                        {
                            if (ladybugToMoveIndex + distanceToMove >= field.Length)
                            {
                                field[ladybugToMoveIndex] = 0;
                                input = Console.ReadLine().Split();
                                continue;
                            }

                            if (field[ladybugToMoveIndex + distanceToMove] == 1)
                            {
                                for (long i = ladybugToMoveIndex + distanceToMove; i < field.Length; i += distanceToMove)
                                {
                                    if (i + distanceToMove >= field.Length && field[i] == 1)
                                    {
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }
                                    else if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[i] = 1;
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }
                                }
                            }
                            else if (field[ladybugToMoveIndex + distanceToMove] == 0)
                            {
                                field[ladybugToMoveIndex + distanceToMove] = 1;
                                field[ladybugToMoveIndex] = 0;
                            }

                        }
                        else if (distanceToMove < 0)
                        {
                            if (ladybugToMoveIndex - distanceToMove < 0)
                            {
                                field[ladybugToMoveIndex] = 0;
                                input = Console.ReadLine().Split();
                                continue;
                            }
                            if (field[ladybugToMoveIndex - distanceToMove] == 1)
                            {
                                for (long i = ladybugToMoveIndex - distanceToMove; i <= -1; i -= distanceToMove)
                                {
                                    if (i - distanceToMove <= -1 && field[i] == 1)
                                    {
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }
                                    else if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[i] = 1;
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }
                                }
                            }
                            else if (field[ladybugToMoveIndex - distanceToMove] == 0)
                            {
                                field[ladybugToMoveIndex - distanceToMove] = 1;
                                field[ladybugToMoveIndex] = 0;
                            }

                        }
                    }
                    else if (directionToMove == "left")
                    {
                        
                        if (distanceToMove > 0)
                        {
                            if (ladybugToMoveIndex - distanceToMove < 0)
                            {
                                field[ladybugToMoveIndex] = 0;
                                input = Console.ReadLine().Split();
                                continue;
                            }
                            if (field[ladybugToMoveIndex - distanceToMove] == 1)
                            {
                                for (long i = ladybugToMoveIndex - distanceToMove; i > -1; i -= distanceToMove)
                                {
                                    if (i + distanceToMove < 0)
                                    {
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }

                                    else if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[i] = 1;
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }
                                }
                            }
                            else if (field[ladybugToMoveIndex - distanceToMove] == 0)
                            {
                                field[ladybugToMoveIndex - distanceToMove] = 1;
                                field[ladybugToMoveIndex] = 0;
                            }

                        }
                        else if (distanceToMove < 0)
                        {
                            distanceToMove = Math.Abs(distanceToMove);
                            if (field[ladybugToMoveIndex + distanceToMove] == 1)
                            {
                                for (long i = ladybugToMoveIndex + distanceToMove; i < field.Length; i += distanceToMove)
                                {
                                    if (i + distanceToMove >= field.Length)
                                    {
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }

                                    else if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[i] = 1;
                                        field[ladybugToMoveIndex] = 0;
                                        break;
                                    }
                                }
                            }
                            else if (field[ladybugToMoveIndex + distanceToMove] == 0)
                            {
                                field[ladybugToMoveIndex + distanceToMove] = 1;
                                field[ladybugToMoveIndex] = 0;
                            }

                        }
                    }
                }
                input = Console.ReadLine().Split();
            }
            foreach (var item in field)
            {
                Console.Write(item + " ");
            }

        }
    }
}
