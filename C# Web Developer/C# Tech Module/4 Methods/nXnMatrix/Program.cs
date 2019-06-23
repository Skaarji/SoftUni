using System;

namespace nXnMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}
