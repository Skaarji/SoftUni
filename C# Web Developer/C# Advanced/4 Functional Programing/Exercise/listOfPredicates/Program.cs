using System;
using System.Collections.Generic;
using System.Linq;

namespace listOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(1, int.Parse(Console.ReadLine())).ToList();

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            for (int i = 0; i < dividers.Length; i++)
            {
                Predicate<int> divisible = x =>
                {
                    if (x % dividers[i] == 0)
                    {
                        return true;
                    }
                    return false;
                    
                };
                numbers = numbers.FindAll(divisible);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
