using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace extractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(@"\").ToArray();
            string[] result = split[split.Length - 1].Split('.').ToArray();
            Console.WriteLine($"File name: {result[0]}");
            Console.WriteLine($"File extension: {result[1]}");
        }
    }
}
