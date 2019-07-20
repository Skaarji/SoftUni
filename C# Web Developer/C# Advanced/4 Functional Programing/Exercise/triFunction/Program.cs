using System;
using System.Collections.Generic;
using System.Linq;

namespace triFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredNumber = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, int, bool> firstFunction = (x, y) =>
            {
                int sumCharacters = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sumCharacters += x[i];
                }
                if (sumCharacters >= y)
                {
                    return true;
                }
                return false;
            };

            names = names.Where(x => firstFunction(x, desiredNumber)).ToList();

            Console.WriteLine(names.FirstOrDefault());
        }
    }
}
