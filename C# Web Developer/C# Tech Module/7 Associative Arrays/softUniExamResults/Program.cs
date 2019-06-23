using System;
using System.Collections.Generic;
using System.Linq;

namespace softUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> languageAndSubmissions = new Dictionary<string, int>();
            Dictionary<string, int> studentsAndScore = new Dictionary<string, int>();

            while (input !="exam finished")
            {
                string[] command = input.Split('-');

                if(command[1] =="banned")
                {
                    studentsAndScore.Remove(command[0]);
                }
                else if (!languageAndSubmissions.ContainsKey(command[1]))
                {
                    languageAndSubmissions.Add(command[1], 1);
                    if (!studentsAndScore.ContainsKey(command[0]))
                    {
                        studentsAndScore.Add(command[0], int.Parse(command[2]));
                    }
                    else if (studentsAndScore.ContainsKey(command[0]) && int.Parse(command[2]) > studentsAndScore[command[0]])
                    {
                        studentsAndScore[command[0]] = int.Parse(command[2]);
                    }
                }
                //Pesho-Java-84
                else if (languageAndSubmissions.ContainsKey(command[1]))
                {
                    languageAndSubmissions[command[1]]++;
                    if (!studentsAndScore.ContainsKey(command[0]))
                    {
                        studentsAndScore.Add(command[0], int.Parse(command[2]));
                    }
                    else if (studentsAndScore.ContainsKey(command[0]) && int.Parse(command[2]) > studentsAndScore[command[0]])
                    {
                        studentsAndScore[command[0]] = int.Parse(command[2]);
                    }

                }
                input = Console.ReadLine();

            }
            Console.WriteLine("Results:");
            foreach (var item in studentsAndScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageAndSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))  
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
