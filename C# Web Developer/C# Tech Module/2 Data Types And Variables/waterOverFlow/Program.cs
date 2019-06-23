using System;

namespace waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int lastFill = 0;
            int currentFill = 0;
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                currentFill += input;

                if(currentFill > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    currentFill = lastFill;
                }
                else
                {
                    lastFill = currentFill;
                }
            }
            Console.WriteLine(lastFill);
        }
    }
}
