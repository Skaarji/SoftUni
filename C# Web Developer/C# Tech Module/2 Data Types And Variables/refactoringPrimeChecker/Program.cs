using System;

namespace refactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int startNum = 2; startNum <=number; startNum++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < startNum; divisor++)
                {
                    if (startNum % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine($"{startNum} -> true");
                }
                else
                {
                    Console.WriteLine($"{startNum} -> false");
                }
            }

        }
    }
}
