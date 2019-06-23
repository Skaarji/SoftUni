using System;

namespace addAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = SumFirstAndSecond(first, second);
            int substract = SubstractThird(third, sum);
            Console.WriteLine(substract);
        }

        private static int SubstractThird(int third, int sum)
        {
            int substract = sum - third;
            return (substract);
        }

        private static int SumFirstAndSecond(int first, int second)
        {
            int sum = first + second;
            return (sum);
        }
    }
}
