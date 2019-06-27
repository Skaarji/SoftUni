using System;
using System.Collections.Generic;
using System.Linq;

namespace LabSimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count>1)
            {
                int value1 = int.Parse(stack.Pop());
                string oper = stack.Pop();
                int value2 = int.Parse(stack.Pop());

                switch (oper)
                {
                    case "-":
                        stack.Push($"{value1 - value2}");
                        break;
                    case "+":
                        stack.Push($"{value1 + value2}");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(stack.Pop());


        }
    }
}
