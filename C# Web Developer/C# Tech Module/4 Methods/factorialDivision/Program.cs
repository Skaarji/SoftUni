using System;
using System.Numerics;

namespace factorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            long factorialA = GetFactorial(a);
            long factorialB = GetFactorial(b);

            double factorialDivision = (double)factorialA / factorialB;

            Console.WriteLine($"{factorialDivision:f2}");

        }
        private static long GetFactorial(long number)
        {
            long result = 1;

            for (long i = 2; i <= number; i++)
            {
                result *= i;
            }
            return (result);
        }
    }
}
