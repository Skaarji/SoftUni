using System;
using System.Collections.Generic;
using System.Linq;

namespace multiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().TrimStart('0').ToCharArray().Select(x => x.ToString( )).ToArray();
            int multiplyer = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            int multiplication = 0;
            int remainder = 0;
            if (multiplyer ==0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(number[i]);
                multiplication =digit * multiplyer;
                multiplication += remainder;
                result.Add(multiplication % 10);
                remainder = multiplication  / 10;

            }
            if (remainder >0)
            {
                result.Add(remainder);
            }            
            result.Reverse();

            Console.WriteLine(String.Join("",result));
        }
    }
}
