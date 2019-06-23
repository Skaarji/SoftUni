using System;

namespace recursiveFibonacci
{
    class Program
    {

        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());


            long[] fibonacii = new long[number+1];
            fibonacii[0] = 0;
            fibonacii[1] = 1;
            for (int i = 2; i < number; i++)
            {
                fibonacii[i] = fibonacii[i - 1] + fibonacii[i - 2];

            }
            Console.WriteLine(fibonacii[number]);
            //    long result = RecursiveFibonacci(number-1);
            //    Console.WriteLine(result);

            //}
            //private static long RecursiveFibonacci(int n)
            //{
            //    if (n <= 1)
            //    {
            //        return 1;
            //    }

            //    return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
            //}


        }
    }
}
