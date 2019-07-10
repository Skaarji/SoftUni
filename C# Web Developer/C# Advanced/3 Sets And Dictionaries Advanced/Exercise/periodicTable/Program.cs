using System;
using System.Collections.Generic;
using System.Linq;

namespace periodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            
            for (int i = 0; i < numberOfLines; i++)
            {
                List<string> compounds = Console.ReadLine().Split().ToList();
                for (int j = 0; j < compounds.Count; j++)
                {
                    elements.Add(compounds[j]);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
