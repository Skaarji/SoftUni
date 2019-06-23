using System;
using System.Text.RegularExpressions;

namespace matchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            var matches = Regex.Matches(numbers, @"(^|(?<=\s))-?\d{1,}([.]\d{1,})?($|(?=\s))");

            Console.WriteLine(String.Join(" ",matches));
        }
    }
}
