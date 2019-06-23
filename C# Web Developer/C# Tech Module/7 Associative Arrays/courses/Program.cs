using System;
using System.Collections.Generic;
using System.Linq;

namespace courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] separate = input.Split(" : ").ToArray();
                string[] name = separate[1].Split().ToArray();

                if (courses.ContainsKey(separate[0]))
                {
                    courses[separate[0]].Add(separate[1]);
                }
                else if (!courses.ContainsKey(separate[0]))
                {
                    courses.Add(separate[0], new List<string>());
                    courses[separate[0]].Add(separate[1]);
                }
                input = Console.ReadLine();
            }

            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var students in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {students}");
                }
            }
        }
    }
}