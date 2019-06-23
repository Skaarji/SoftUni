using System;

namespace fromLeftToRight
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();                
                string[] splitNumbers = numbers.Split(' ');

                long left = long.Parse(splitNumbers[0]);
                long right = long.Parse(splitNumbers[1]);

                long greater = right;
                if (left > right)
                {
                    greater = left;
                }

                long sum = 0;
                while (greater != 0)
                {
                    sum += greater % 10;
                    greater /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}