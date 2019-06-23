using System;
using System.Linq;

namespace carRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int raceLenght = array.Length / 2;
            double leftcar = 0;
            double rightcar = 0;

            for (int i = 0; i < raceLenght; i++)
            {
                if (array[i] == 0)
                {
                    leftcar =leftcar* 0.8;
                }
                else
                {
                    leftcar += array[i];
                }                
            }
            for (int i = array.Length-1; i > raceLenght; i--)
            {
                if(array[i]==0)
                {
                    rightcar =rightcar*0.8;
                }
                else
                {
                    rightcar +=array[i];
                }                
            }
            if (leftcar < rightcar)
            {
                Console.WriteLine($"The winner is left with total time: {leftcar}");
            }
            else if (rightcar < leftcar)
            {
                Console.WriteLine($"The winner is right with total time: {rightcar}");
            }

        }
    }
}
