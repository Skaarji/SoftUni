using System;

namespace spiceFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            long startingYield = long.Parse(Console.ReadLine());
            long totalYield = 0;
            int counter = 0;

            while (startingYield >= 100)
            {
                totalYield += startingYield - 26;
                startingYield -= 10;
                counter++;
            }

            if (totalYield >= 26)
            {
                totalYield -= 26;
            }

            Console.WriteLine(counter);
            Console.WriteLine(totalYield);

        }
    }
}
