using System;

namespace tripplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                char firstCharacter = (char)('a' + i);
                for (int j = 0; j < number; j++)
                {
                    char secondCharacter = (char)('a' + j);
                    for (int k = 0; k < number; k++)
                    {
                        char thirdCharacter = (char)('a' + k);
                        Console.WriteLine($"{firstCharacter}{secondCharacter}{thirdCharacter}");
                    }
                }
            }
        }
    }
}
