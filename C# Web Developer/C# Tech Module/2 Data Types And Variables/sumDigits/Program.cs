using System;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int sum = 0;

            while (number > 9)
            {

                int lastdigit = number % 10;
                sum += lastdigit;
                number = number / 10;


            }
            sum += number;
            Console.WriteLine(sum);
        }
    }
}
