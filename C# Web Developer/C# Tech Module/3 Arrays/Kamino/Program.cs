using System;
using System.Linq;

namespace Kamino
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int longestSequenceLenght = -1;
            int bestSequenceIndex = -1;
            int bestSequenceSum = -1;
            int[] bestSequence = new int[sequenceLenght];
            int counter = 1;
            int longestcounter = 0;



            while (input != "Clone them!")
            {
                int[] sequence = input
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                int sequenceCounter = 0;
                int currentSequenceLenght = 0;
                int currentSequenceIndex = -1;
                int currentSequenceSum = 0;


                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        currentSequenceSum++;
                        sequenceCounter++;

                        if (sequenceCounter > currentSequenceLenght)
                        {
                            currentSequenceLenght = sequenceCounter;
                            currentSequenceIndex = i - sequenceCounter;
                        }
                    }
                    else
                    { sequenceCounter = 0; }
                }
                if (currentSequenceLenght  > longestSequenceLenght)
                {
                    longestSequenceLenght = currentSequenceLenght;
                    bestSequenceIndex = currentSequenceIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequence = sequence;
                    longestcounter = counter;
                }
                else if (currentSequenceLenght == longestSequenceLenght 
                    && currentSequenceIndex < bestSequenceIndex)
                {
                    bestSequenceIndex = currentSequenceIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequence = sequence;
                    longestcounter = counter;
                }
                else if (currentSequenceLenght==longestSequenceLenght
                    && currentSequenceIndex == bestSequenceIndex
                    && currentSequenceSum > bestSequenceSum)
                {
                    bestSequenceSum = currentSequenceSum;                    
                    bestSequence = sequence;
                    longestcounter = counter;
                }


                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {longestcounter} with sum: {bestSequenceSum}.");
            foreach (var item in bestSequence)
            {
                Console.Write(item + " ");
            }
        }
    }
}
