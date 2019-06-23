using System;
using System.Linq;
using System.Collections.Generic;


namespace bombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == bomb)
                {
                    int counter = 0;
                    while (listOfNumbers.Count > i + 1 && counter < power)
                    {
                        listOfNumbers.RemoveAt(i + 1);
                        counter++;
                    }
                    counter = 0;
                    int currentIndex = i;

                    for (int j = currentIndex; j >= 0; j--)
                    {
                        counter++;                        
                        listOfNumbers.RemoveAt(j);
                        if (counter > power || j - 1 < 0)
                        {                            
                            break;
                        }
                    }
                    i--;
                    
                }

               
            }
            int sum = 0;
            foreach (var item in listOfNumbers)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
