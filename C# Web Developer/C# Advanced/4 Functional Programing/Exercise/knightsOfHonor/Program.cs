using System;
using System.Linq;

namespace knightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] knights = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => "Sir"+" "+x)
                .ToArray();

            foreach (var item in knights)
            {
                Print(item);
            }
            
        }
        public static Action<string> Print = x => Console.WriteLine(x);
    }
}
