using System;
using System.Collections.Generic;
using System.Linq;

namespace anonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mainList = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (endIndex > mainList.Count - 1 || endIndex < 0)
                    {
                        endIndex = mainList.Count - 1;
                    }
                    if (startIndex > mainList.Count || startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    string mergedIndex = "";
                    int counter = startIndex;
                    while (counter <= endIndex)
                    {
                        mergedIndex += mainList[startIndex];
                        mainList.RemoveAt(startIndex);
                        counter++;
                    }
                    counter = 0;
                    mainList.Insert(startIndex, mergedIndex);
                }
                else if (command[0] == "divide")
                {
                    int indexToDivide = int.Parse(command[1]);
                    int partToDivideInto = int.Parse(command[2]);
                    List<string> divided = new List<string>();
                    string toBeDivided = mainList[indexToDivide];
                    mainList.RemoveAt(indexToDivide);
                    int partsSize = toBeDivided.Length / partToDivideInto;

                    for (int i = 0; i < partToDivideInto; i++)
                    {
                        if (i == partToDivideInto - 1)
                        {
                            divided.Add(toBeDivided.Substring(i * partsSize));
                        }
                        else
                        {
                            divided.Add(toBeDivided.Substring(i * partsSize, partsSize));
                        }
                    }
                    mainList.InsertRange(indexToDivide, divided);

                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", mainList));
        }
    }
}
