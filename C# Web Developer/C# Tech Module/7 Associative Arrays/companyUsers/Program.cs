using System;
using System.Collections.Generic;
using System.Linq;

namespace companyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, List<string>> companyList = new SortedDictionary<string, List<string>>();

            while (input != "End")
            {
                string[] split = input.Split(" -> ").ToArray();

                if (!companyList.ContainsKey(split[0]))
                {
                    companyList.Add(split[0], new List<string>());
                    companyList[split[0]].Add(split[1]);
                }
                else if (companyList.ContainsKey(split[0]))
                {
                    if (!companyList[split[0]].Contains(split[1]))
                    {
                        companyList[split[0]].Add(split[1]);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var company in companyList)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
