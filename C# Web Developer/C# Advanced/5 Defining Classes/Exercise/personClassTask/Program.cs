using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);               
            }
            people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
            
        }
    }
}
