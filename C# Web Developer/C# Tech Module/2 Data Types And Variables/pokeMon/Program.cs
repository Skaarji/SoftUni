using System;

namespace pokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustion = int.Parse(Console.ReadLine());
            int counter = 0;
            int startingPower = pokePower;

            while (pokePower >= distance)
            {

                pokePower -= distance;
                counter++;
                if (pokePower == startingPower / 2 && exaustion > 0)
                {
                    pokePower = pokePower / exaustion;
                }

            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
