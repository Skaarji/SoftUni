using System;
using System.Collections.Generic;

namespace evenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < numberOfLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, 1);
                }
                else
                {
                    dict[input]++;
                }
            }
            foreach (var item in dict)
            {
                if (item.Value % 2 == 0)
                    Console.WriteLine(item.Key);
            }
        }
    }
}
