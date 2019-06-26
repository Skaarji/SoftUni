using System;
using System.Collections.Generic;

namespace LabReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<Char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            int count = stack.Count;
            for (int i = 0; i < count ; i++)
            {
                Console.Write(stack.Pop());

            }
            //while (stack.Count != 0)
            //{
            //    Console.Write(stack.Pop());
            //}
            Console.WriteLine();


        }
    }
}
