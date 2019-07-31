using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public string FirstName { get;private set; }
        public string LastName { get;private set; }
        public int Age { get; private set; }

        public decimal Salary { get; private set; }
        

        public Person(string firstName, string lastName, int age,decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal increaase)
        {
            if (Age<30)
            {
              Salary += Salary * increaase/200;
            }
            else
            {
                Salary += Salary * increaase / 100;
            }
        }
    }
}
