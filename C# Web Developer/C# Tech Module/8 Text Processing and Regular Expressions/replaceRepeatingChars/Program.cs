using System;
using System.Text.RegularExpressions;

namespace replaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var matches = Regex.Matches(text, @"([a-z])\1{1,}");

            foreach (Match item in matches)
            {
                string match = item.ToString();
                string letter = item.Groups[1].ToString();
                string replaced= text.Replace(match, letter);
                text = replaced;
            }
            Console.WriteLine(text);
        }
    }
}
