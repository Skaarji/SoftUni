using System;
using System.Collections.Generic;
using System.Linq;

namespace appendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> innitalList = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> finalList = new List<int>();
            for (int i = 0; i < innitalList.Count; i++)
            {
                List<int> tempList = innitalList[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();                
                finalList.AddRange(tempList);
            }
            
            Console.WriteLine(String.Join(" ",finalList));
        }
    }
}
