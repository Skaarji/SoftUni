using System;
using System.Collections.Generic;
using System.Linq;

namespace orderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split().ToList();
            List<Person> list = new List<Person>();

            while (command[0] != "End")
            {
                Person person = new Person();
                person.Name = command[0];
                person.ID = command[1];
                person.Age = int.Parse(command[2]);

                list.Add(person);
                command = Console.ReadLine().Split().ToList();

            }
            if (command[0] == "End")
            {
                var result = list.OrderBy(person =>person.Age);
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
                }
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
