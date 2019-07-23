using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> family;

        public Family()
        {
           family = new List<Person>();
        }

        public void AddMember(Person member)
        {
           family.Add(member);
        }

        public Person GetOldest()
        {
            var tempFamily = family.OrderByDescending(x => x.Age).ToList();
            return tempFamily[0];
        }
    }
}
