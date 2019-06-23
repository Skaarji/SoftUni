using System;
using System.Collections.Generic;

namespace takeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedString = Console.ReadLine();
            List<int> numberList = new List<int>();
            List<string> nonNumberList = new List<string>();

            for (int i = 0; i < encryptedString.Length; i++)
            {
                char symbol = encryptedString[i];

                if (char.IsDigit(symbol))
                {
                    numberList.Add(int.Parse(symbol.ToString()));
                }
                else
                {
                    nonNumberList.Add(symbol.ToString());
                }
            }
            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            for (int i = 0; i < numberList.Count; i += 2)
            {
                if (i == numberList.Count - 1)
                {
                    take.Add(numberList[i]);
                }
                else
                {
                    take.Add(numberList[i]);
                    skip.Add(numberList[i + 1]);

                }
            }
            List<string> result = new List<string>();
            for (int i = 0; i < take.Count; i++)
            {
                for (int j = 0; j < take[i]; j++)
                {
                    if (j > nonNumberList.Count - 1)
                    {
                        Console.WriteLine(String.Join("", result));
                        return;
                    }
                    result.Add(nonNumberList[j]);
                }
                nonNumberList.RemoveRange(0, take[i] + skip[i]);
            }
            Console.WriteLine(String.Join("", result));
        }
    }
}
