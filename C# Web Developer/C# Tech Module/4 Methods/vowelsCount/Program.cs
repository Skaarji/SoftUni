using System;

namespace vowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(returnNumberOfVowels(input));
        }

        private static int returnNumberOfVowels(string input)
        {

            int counter = 0;

            char[] letters = new char[input.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = input[i];
                if (letters[i] == 'a'
            || letters[i] == 'e'
            || letters[i] == 'i'
            || letters[i] == 'o'
            || letters[i] == 'u'
            || letters[i] == 'A'
            || letters[i] == 'E'
            || letters[i] == 'I'
            || letters[i] == 'O'
            || letters[i] == 'U')
                {
                    counter++;
                }
            }
            return (counter);
        }
    }
}
