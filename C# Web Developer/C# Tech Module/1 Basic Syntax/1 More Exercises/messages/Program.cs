using System;

namespace messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cycle = int.Parse(input);
            input = Console.ReadLine();
            for (int i = 1; i <= cycle; i++)
            {
                int number = int.Parse(input);
                int lenght = input.Length;
                int mainDigit = (number + 10) % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 0)
                {
                    Console.Write($" ");
                    input = Console.ReadLine();
                    continue;
                }
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }                               
                int letterIndex = (offset + lenght - 1) + 97;
                Console.Write((char)letterIndex);
                input = Console.ReadLine();

            }



        }
    }
}
