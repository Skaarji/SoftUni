using System;
using System.Numerics;

namespace snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string biggestFormula = " ";
            BigInteger bestSnowball = -1;
            for (int i = 0; i < number; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    biggestFormula = ($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
                }
            }
            Console.WriteLine(biggestFormula);
        }
    }
}
