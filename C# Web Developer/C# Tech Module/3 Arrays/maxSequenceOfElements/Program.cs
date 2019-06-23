using System;
using System.Linq;

namespace maxSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int counterLongest = 0;
            int counter = 0;            
            int sequenceNumber =0;
            

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i ; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                        
                        if (counter > counterLongest)
                        {
                            counterLongest = counter;
                            sequenceNumber = array[i];
                        }
                    }
                    else
                    {
                        counter = 0;
                        break;
                    }
                }
                counter = 0;
            }
            int[] sequence =new int[counterLongest];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = sequenceNumber;
            }
            foreach (var item in sequence)
            {
                Console.Write(item+ " ");
            }

        }
    }
}
