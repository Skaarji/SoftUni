using System;

namespace decryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                char input =char.Parse(Console.ReadLine());
                Console.Write((char)(key + input));
            }
        }
    }
}
