using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace rageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            var matches = Regex.Matches(input, @"([\D]{1,})(\d{1,})");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matches.Count; i++)
            {
                string repeats = matches[i].Groups[2].ToString();
                string stringToRepeat = matches[i].Groups[1].ToString();
                for (int j = 0; j < int.Parse(repeats); j++)
                {
                    sb.Append(stringToRepeat);
                }
            }
            var count = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");

            Console.WriteLine(sb);

        }
    }
}
