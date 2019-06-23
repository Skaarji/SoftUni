using System;
using System.Linq;

namespace zigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string string1 = "";
            string string2 = "";

            for (int i = 1; i <= input; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                if (i % 2 != 0)
                {
                    string1 += ($"{numbers[0]} ");
                    string2 += ($"{numbers[1]} ");
                }
                else
                {
                    string1 += ($"{numbers[1]} ");
                    string2 += ($"{numbers[0]} ");

                }
            }
            int[] numbers1 = string1
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] numbers2 = string2
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(String.Join(" ", numbers1));


            Console.WriteLine(String.Join(" ", numbers2));



        }
    }
}
