using System;
using System.Linq;

namespace customMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> smallest = num =>
             {
                 int minvalue = int.MaxValue;
                 foreach (var n in num)
                 {
                     if (n < minvalue)
                     {
                         minvalue = n;
                     }                     
                 }
                 return minvalue;
             };
            Console.WriteLine(smallest(numbers));
        }
    }
}
