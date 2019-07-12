using System;
using System.Collections.Generic;
using System.Linq;

namespace setsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int set1Length = lenghts[0];
            int set2Length = lenghts[1];
            List<int> set1 = new List<int>();
            SortedSet<int> set2 = new SortedSet<int>();
            for (int i = 0; i < set1Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!set1.Contains(input))
                {
                    set1.Add(input);
                }
            }
            for (int i = 0; i < set2Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                set2.Add(input);
            }
            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
