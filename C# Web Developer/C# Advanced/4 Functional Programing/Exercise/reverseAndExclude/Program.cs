using System;
using System.Linq;

namespace reverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();
            int divisor = int.Parse(Console.ReadLine());
            numbers = numbers.Where(x => x % divisor !=0).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
