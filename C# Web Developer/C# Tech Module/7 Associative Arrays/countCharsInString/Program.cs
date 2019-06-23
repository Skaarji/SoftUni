using System;
using System.Collections.Generic;
using System.Linq;

namespace countCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray().Where(x => !x.Equals(' ')).ToArray();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var cha in input)
            {
                if (result.ContainsKey(cha))
                {
                    result[cha]++;
                }
                else if (!result.ContainsKey(cha))
                {
                    result.Add(cha, 1);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
