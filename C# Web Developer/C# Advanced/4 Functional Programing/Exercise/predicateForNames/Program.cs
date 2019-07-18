using System;
using System.Linq;

namespace predicateForNames
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int desiredLenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length <= desiredLenght)
                .ToArray();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
