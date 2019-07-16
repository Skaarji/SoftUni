using System;
using System.Collections.Generic;
using System.Linq;

namespace findEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lower = bounds[0];
            int upper = bounds[1];
            List<int> numbers = new List<int>();

            string type = Console.ReadLine();

            for (int i = lower; i <= upper; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = number =>
            {

                if (number % 2 == 0)
                {
                    return true;
                }
                return false;
            };

            Predicate<int> isOdd = number => number % 2 != 0;

            numbers =numbers.Where(x => type == "odd" ? isOdd(x) : isEven(x)).ToList();

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
