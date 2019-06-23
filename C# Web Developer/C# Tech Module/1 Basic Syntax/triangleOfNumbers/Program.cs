using System;

namespace triangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter =0;

            for (int i = 1; i <= n; i++)
            {
                while (counter < i)
                {
                    Console.Write($"{i} ");
                    counter++;
                }
                counter = 0;
                Console.WriteLine();
            }
        }
    }
}
