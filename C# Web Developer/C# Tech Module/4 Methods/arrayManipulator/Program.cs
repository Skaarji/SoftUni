using System;
using System.Linq;
using System.Collections.Generic;

namespace arrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "exchange")
                {
                    int indexToSplitAfter = int.Parse(command[1]);
                    if (indexToSplitAfter >= array.Length || indexToSplitAfter < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        array = exchange(array, indexToSplitAfter);
                    }
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "odd")
                    {
                        PrintMaxOddIndex(array);
                    }
                    else if (command[1] == "even")
                    {
                        PrintMaxEvenIndex(array);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "odd")
                    {
                        PrintMinOddIndex(array);
                    }
                    else if (command[1] == "even")
                    {
                        PrintMinEvenIndex(array);
                    }
                }
                else if (command[0] == "first")
                {
                    if (int.Parse(command[1]) > array.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid count");                        
                    }
                    else
                    {
                        PrintFirstEvenOdd(array, command);
                    }
                }
                else if (command[0] == "last")
                {
                    if (int.Parse(command[1]) > array.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid count");                        
                    }
                    else
                    {
                        PrintLastOddEven(array, command);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ", array)}]");
        }

        private static void PrintLastOddEven(int[] array, string[] command)
        {
            int counter = 0;
            List<int> list = new List<int>();
            if (command[2] == "odd")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        list.Add(array[i]);
                        counter++;
                        if (counter >= int.Parse(command[1]))
                        {
                            break;
                        }
                    }
                }
            }
            else if (command[2] == "even")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        list.Add(array[i]);
                        counter++;
                        if (counter >= int.Parse(command[1]))
                        {
                            break;
                        }
                    }

                }
            }
            list.Reverse();
            Console.WriteLine($"[{String.Join(", ", list)}]");
        }

        private static void PrintFirstEvenOdd(int[] array, string[] command)
        {
            int counter = 0;
            List<int> list = new List<int>();
            if (command[2] == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        list.Add(array[i]);
                        counter++;
                        if (counter >= int.Parse(command[1]))
                        {
                            break;
                        }
                    }
                }
            }
            else if (command[2] == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        list.Add(array[i]);
                        counter++;
                        if (counter >= int.Parse(command[1]))
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"[{String.Join(", ", list)}]");
        }

        private static void PrintMaxOddIndex(int[] array)
        {
            int max = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] >= max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            if (max == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        private static void PrintMaxEvenIndex(int[] array)
        {
            int max = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] >= max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            if (max == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        private static void PrintMinEvenIndex(int[] array)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] <= min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            if (min == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        private static void PrintMinOddIndex(int[] array)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] <= min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            if (min == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        private static int[] exchange(int[] array, int indexToSplitAfter)
        {
            int currentNumber = 0;
            for (int i = 0; i < array.Length - 1 - indexToSplitAfter; i++)
            {
                currentNumber = array[array.Length - 1];
                for (int j = array.Length - 1; j >= 1; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = currentNumber;
            }
            return array;
        }
    }
}
