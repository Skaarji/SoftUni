using System;
using System.Linq;

namespace palindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (input != "END")
            {

                string reversedInput = ReverseInput(input);

                if (input == reversedInput)
                {
                    Console.WriteLine("true");
                }
                else if (input != reversedInput)
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }

        private static string ReverseInput(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reversedString = String.Join("", array);
            return (reversedString);


        }
    }
}
