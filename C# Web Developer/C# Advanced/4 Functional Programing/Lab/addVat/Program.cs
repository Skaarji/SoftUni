using System;
using System.Linq;

namespace addVat
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => (x * 1.2))
                .ToArray();

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"{prices[i]:f2}");
            }
        } 
    }
}
