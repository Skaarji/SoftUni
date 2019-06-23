using System;
using System.Collections.Generic;
using System.Linq;


namespace cardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listA = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listB = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (listA.Count>0 && listB.Count>0)
            {
                if (listA[0]>listB[0])
                {
                    listA.Add(listA[0]);
                    listA.Add(listB[0]);
                    listA.RemoveAt(0);
                    listB.RemoveAt(0);
                }
                else if (listA[0]<listB[0])
                {
                    listB.Add(listB[0]);
                    listB.Add(listA[0]);
                    listB.RemoveAt(0);
                    listA.RemoveAt(0);

                }
                else if (listA[0]==listB[0])
                {
                    listA.RemoveAt(0);
                    listB.RemoveAt(0);
                }
            }
            int sum = 0;
            if (listA.Count == 0)
            {                
                for (int i = 0; i < listB.Count; i++)
                {
                    sum += listB[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else if (listB.Count==0)
            {
                for (int i = 0; i < listA.Count; i++)
                {
                    sum += listA[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }


        }
    }
}
