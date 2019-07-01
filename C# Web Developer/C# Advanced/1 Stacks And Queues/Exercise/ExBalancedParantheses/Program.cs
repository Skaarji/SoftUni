using System;
using System.Collections.Generic;
using System.Linq;

namespace ExBalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stackofPar = new Stack<char>();

            char[] openPar = new char[] { '(', '{', '[' };

            bool isValid = true;
            foreach (var item in input)
            {
                if (openPar.Contains(item))
                {
                    stackofPar.Push(item);
                    continue;
                }
                if (stackofPar.Count==0)
                {
                    isValid = false;
                    break;
                }
                else if (stackofPar.Peek()== '(' && item == ')')
                {
                    stackofPar.Pop();
                }
                else if (stackofPar.Peek()== '{' && item == '}')
                {
                    stackofPar.Pop();
                }
                else if (stackofPar.Peek()== '[' && item == ']')
                {
                    stackofPar.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
