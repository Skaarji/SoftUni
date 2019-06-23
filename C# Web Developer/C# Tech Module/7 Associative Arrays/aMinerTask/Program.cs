using System;
using System.Collections.Generic;

namespace aMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> result = new Dictionary<string, int>();
            int counter = 0;

            while (input != "stop")
            {
                counter++;

                if (counter % 2 != 0)
                {
                    if (result.ContainsKey(input))
                    {
                        result[input] += int.Parse(Console.ReadLine());
                        counter++;
                    }
                    else if (!result.ContainsKey(input))
                    {
                        result.Add(input, int.Parse(Console.ReadLine()));
                        counter++;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
