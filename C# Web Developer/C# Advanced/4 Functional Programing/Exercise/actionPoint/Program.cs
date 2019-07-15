using System;
using System.Linq;

namespace actionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in names)
            {
                Print(item);
            }
        }
        public static Action<string> Print = n => Console.WriteLine(n);
        
        
    }
}
