using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var listOfStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();

                var student = new Student();

                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = double.Parse(input[2]);

                listOfStudents.Add(student);

            }           

            listOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, listOfStudents));


        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }

    }
}
