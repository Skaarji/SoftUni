using System;
using System.Collections.Generic;
using System.Linq;

namespace studentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentLog = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentLog.ContainsKey(student))
                {
                    studentLog[student].Add(grade);
                }
                else if(studentLog.ContainsKey(student)==false)
                {
                    studentLog.Add(student, new List<double>());
                    studentLog[student].Add(grade);
                }
            }
            studentLog = studentLog
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in studentLog)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }

        }
    }
}
