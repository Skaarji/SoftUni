using System;

namespace middleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacters(input);

        }

        private static void PrintMiddleCharacters(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[(input.Length / 2) - 1]}{input[input.Length / 2]}");
            }
            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[(input.Length / 2)]);
            }
        }
    }
}
