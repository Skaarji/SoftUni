using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public string Date1 { get; set; }

        public string Date2 { get; set; }



        public int difference(string date1, string date2)
        {
            int[] firstDate = date1.Split(" ").Select(int.Parse).ToArray();
            int[] secondDate = date2.Split(" ").Select(int.Parse).ToArray();
            DateTime dateOne = new DateTime(firstDate[0],firstDate[1],firstDate[2]);
            DateTime dateTwo = new DateTime(secondDate[0],secondDate[1],secondDate[2]);

            TimeSpan dif = dateOne - dateTwo;

            return Math.Abs((dateOne - dateTwo).Days);

            
        }

    }
}
