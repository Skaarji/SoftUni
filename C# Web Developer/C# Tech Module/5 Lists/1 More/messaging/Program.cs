using System;
using System.Collections.Generic;
using System.Linq;

namespace messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            List<char> splitText = text.ToCharArray().ToList();
            string result = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> sequence = numbers[i].ToString().Select(digit => int.Parse(digit.ToString())).ToList();
                int sequenceSum = 0;
                for (int j = 0; j < sequence.Count; j++)
                {
                    
                    sequenceSum += sequence[j];
                }
                int indexToTake = -1;
                if (sequenceSum > splitText.Count)
                {
                   indexToTake = sequenceSum % splitText.Count;
                }
                else
                {
                    indexToTake = sequenceSum;
                }
                result += splitText[indexToTake];
                splitText.RemoveAt(indexToTake);                   
            }
            Console.WriteLine(result);
        }
    }
}
