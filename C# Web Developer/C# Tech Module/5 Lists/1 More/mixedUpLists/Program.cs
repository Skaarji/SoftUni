using System;
using System.Collections.Generic;
using System.Linq;

namespace mixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mix = new List<int>();
            List<int> range = new List<int>();

            if(listOne.Count>listTwo.Count)
            {
                range.Add(listOne[listOne.Count - 2]);
                range.Add(listOne[listOne.Count - 1]);
                listOne.RemoveRange(listOne.Count - 2, 2);
            }
            else if (listOne.Count<listTwo.Count)
            {
                range.Add(listTwo[0]);
                range.Add(listTwo[1]);
                listTwo.RemoveRange(0, 2);
            }

            for(int i = 0; i < listOne.Count; i++)
            {
                mix.Add(listOne[i]);
                mix.Add(listTwo[listTwo.Count - 1 - i]);
            }
            for (int i = 0; i < mix.Count; i++)
            {
                range.Sort();

                if(mix[i]<=range[0] || mix[i] >= range[1] )
                {
                    mix.RemoveAt(i);
                    i--;
                }
            }
            mix.Sort();
            Console.WriteLine(String.Join(" ",mix));

        }
    }
}
