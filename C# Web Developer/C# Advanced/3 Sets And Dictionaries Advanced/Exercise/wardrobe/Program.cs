using System;
using System.Collections.Generic;

namespace wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if(!wardrobe[color].ContainsKey(clothes[j]))
                        {
                            wardrobe[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            wardrobe[color][clothes[j]]++;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!wardrobe[color].ContainsKey(clothes[j]))
                        {
                            wardrobe[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            wardrobe[color][clothes[j]]++;
                        }
                    }
                }
            }
            string[] clothesToFind = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {               
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == clothesToFind[0] && item.Key == clothesToFind[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
