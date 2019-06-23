using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> initialDrumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            List<int> currentDrumSet = new List<int>();
            for (int i = 0; i < initialDrumSet.Count; i++)
            {
                currentDrumSet.Add(initialDrumSet[i]);
            }
            
            double currentSavings = savings;

            while (command !="Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    if (currentDrumSet[i] == -2000)
                    {
                        continue;
                    }                    
                    currentDrumSet[i] -= hitPower;
                    if (currentDrumSet[i] <=0)
                    {                        
                        currentSavings -= initialDrumSet[i] * 3;
                        if(currentSavings < 0)
                        {
                            currentDrumSet[i] = -2000;
                            currentSavings = savings;
                        }
                        else if (currentSavings>=0)
                        {
                            currentDrumSet[i] = initialDrumSet[i];
                            savings = currentSavings;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            currentDrumSet = currentDrumSet.Where(x => x != -2000).ToList();
            Console.WriteLine(String.Join(" ",currentDrumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");

        }
    }
}
