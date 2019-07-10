using System;
using System.Collections.Generic;
using System.Linq;

namespace ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            while (input != "end of contests")
            {
                string[] command = input.Split(":");

                contests.Add(command[0], command[1]);

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input !="end of submissions")
            {
                string[] command = input.Split("=>");

                string contName = command[0];
                string contPass = command[1];
                string user = command[2];
                int points = int.Parse(command[3]);

                if (!contests.ContainsKey(contName) || contests[contName]!= contPass)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (!students.ContainsKey(user))
                {
                    students.Add(user, new Dictionary<string, int>());
                    students[user].Add(contName, points);
                    input = Console.ReadLine();
                    continue;
                }
                if (!students[user].ContainsKey(contName))
                {
                    students[user].Add(contName, points);
                    input = Console.ReadLine();
                    continue;
                }
                if (students[user][contName] < points)
                {
                    students[user][contName] = points;
                }
                input = Console.ReadLine();

            }
            var topStudents = students.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in topStudents)
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
                break;
            }
            Console.WriteLine("Ranking:");

            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                Dictionary<string, int> dict = student.Value;
                foreach (var item in dict.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }

            }


        }
    }
}
