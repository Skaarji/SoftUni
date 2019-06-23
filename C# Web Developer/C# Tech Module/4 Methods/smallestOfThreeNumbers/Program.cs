using System;

namespace smallesOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            printSmallest(numbers);
        }

        private static void printSmallest(int[] numbers)
        {
            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);
        }
    }
}
