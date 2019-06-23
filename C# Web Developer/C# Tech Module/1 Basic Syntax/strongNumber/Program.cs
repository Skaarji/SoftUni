using System;

namespace strongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int currentNumber = inputNumber;
            int total = 0;
            int totalNumber = 0;

            while (currentNumber > 0)
            {
                int lastnumber = currentNumber % 10;

                if (lastnumber == 0)
                {
                    totalNumber += 1;
                }
                total = lastnumber;

                for (int i = lastnumber - 1; i > 0; i--)
                {
                    total = total * i;
                }
                totalNumber += total;
                total = 0;
                currentNumber = currentNumber / 10;
            }
            if (totalNumber == inputNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
