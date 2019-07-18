using System;
using System.Collections.Generic;
using System.Linq;

namespace partyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string filter = Console.ReadLine();

            List<string> filters = new List<string>();

            while (filter != "Print")
            {
                string[] filterData = filter.Split(';');

                string action = filterData[0];

                if (action == "Add filter")
                {
                    filters.Add($"{filterData[1]};{filterData[2]}");
                }
                else if (action == "Remove filter")
                {
                    filters.Remove($"{filterData[1]};{filterData[2]}");
                }

                filter = Console.ReadLine();
            }            

            Func<string, string, bool> startsWith = (x, y) => x.StartsWith(y);
            Func<string, string, bool> endsWith = (x, y) => x.EndsWith(y);
            Func<string, string, bool> length = (x, y) => x.Length==int.Parse(y);
            Func<string, string, bool> contains = (x, y) => x.Contains(y);

            foreach (var fil in filters)
            {
                string[] currentFilter = fil.Split(';');
                string filterType = currentFilter[0];
                string filterValue = currentFilter[1];

                people = people
                    .Where(x => filterType == "Starts with" ? !startsWith(x, filterValue) : true)
                    .Where(x => filterType == "Ends with" ? !endsWith(x, filterValue) : true)
                    .Where(x => filterType == "Length" ? !length(x, filterValue) : true)
                    .Where(x => filterType == "Contains" ? !contains(x, filterValue) : true)
                    .ToList();        
            }
            Console.WriteLine(string.Join(" ",people));


        }
    }
}
