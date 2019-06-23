using System;
using System.Linq;

namespace characterMultiplyer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            char[] array1 = input[0].ToCharArray();
            char[] array2 = input[1].ToCharArray();
            int sum = 0;

            if (array1.Length >= array2.Length)
            {

                for (int i = 0; i < array2.Length; i++)
                {
                    sum += array1[i] * array2[i];
                }
                for (int i = array2.Length; i < array1.Length; i++)
                {
                    sum += array1[i];
                }
            }
            else if ( array1.Length <= array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    sum += array1[i] * array2[i];
                }
                for (int i = array1.Length; i < array2.Length; i++)
                {
                    sum += array2[i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}
