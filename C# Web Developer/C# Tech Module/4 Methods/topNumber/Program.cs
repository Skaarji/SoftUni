using System;
using System.Linq;

namespace topNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < input; i++)
            {
                string numberToString = i.ToString();
                char[] array = numberToString.ToCharArray();
                int numberSum = 0;
                Boolean hasOdd = false;
                for (int j = 0; j < numberToString.Length; j++)
                {
                    numberSum += array[j];
                    if (array[j] % 2 !=0)
                    {
                        hasOdd = true;
                    }
                }
                if (numberSum % 8 ==0 && hasOdd==true)
                {
                    Console.WriteLine(i);
                }             

            }           

        }
    }
}
