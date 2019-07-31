using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private int age;
        private string lastName;
        private string firstName;
        private decimal salary;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }


        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }


        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value<460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                salary = value;
            }
        }


        public Person(string firstName, string lastName, int age, decimal salary)
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
            if (Age < 30)
            {
                Salary += Salary * increaase / 200;
            }
            else
            {
                Salary += Salary * increaase / 100;
            }
        }

    }
}
