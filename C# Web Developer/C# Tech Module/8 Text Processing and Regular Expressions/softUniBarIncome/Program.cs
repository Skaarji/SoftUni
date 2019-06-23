using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            int secondNumber = int.Parse(Console.ReadLine().TrimStart(new char[] { '0' }));

            if (secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }


            var finalResult = new List<int>();
            int residual = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {

                int digit = int.Parse(firstNumber[i].ToString());
                int result = digit * secondNumber + residual;
                residual = 0;

                if (result <= 9)
                {
                    finalResult.Add(result);
                }
                else
                {
                    finalResult.Add(result % 10);
                    residual = result / 10;
                }
            }
            if (residual != 0)
            {
                finalResult.Add(residual);
            }

            finalResult.Reverse();

            Console.WriteLine(string.Join("", finalResult));
        }
    }
}