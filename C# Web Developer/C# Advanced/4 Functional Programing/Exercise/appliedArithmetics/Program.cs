using System;
using System.Linq;

namespace appliedArithmetics
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToArray();
                }
                else if (input=="add")
                {
                    numbers = numbers.Select(x => x + 1).ToArray();
                }
                else if (input == "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToArray();
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
                input = Console.ReadLine();
            }
        }
    }
}
