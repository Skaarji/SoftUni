using System;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] passangers = new int[input];
            for (int i = 0; i < input; i++)
            {
                int singleNumber = int.Parse(Console.ReadLine());
                passangers[i] = singleNumber;
                sum += passangers[i];
            }
            Console.WriteLine(String.Join(' ', passangers));
            Console.WriteLine(sum);
        }
    }
}
