using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace activationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> keys = Console.ReadLine().Split('&').ToList();

            for (int i = 0; i < keys.Count; i++)
            {
                var shorter16 = Regex.IsMatch(keys[i], @"^[A-Za-z0-9]{16}$");
                var longer25 = Regex.IsMatch(keys[i], @"^[A-Za-z0-9]{25}$");
                if (shorter16 == false && longer25 == false)
                {
                    keys.RemoveAt(i);
                    i--;
                }
                else if (shorter16 == true)
                {
                    List<string> listOfStrings = keys[i].ToCharArray().Select(x => x.ToString()).ToList();
                    for (int k = 0; k < listOfStrings.Count; k++)
                    {
                        if (char.IsDigit(char.Parse(listOfStrings[k])))
                        {
                            listOfStrings[k] = (9 - int.Parse(listOfStrings[k])).ToString();
                        }
                    }
                    keys[i] = String.Join("", listOfStrings);

                    keys[i] = keys[i].ToUpper();
                    for (int j = 4; j < keys[i].Length; j += 5)
                    {
                        keys[i] = keys[i].Insert(j, "-");
                    }
                }
                else if (longer25 == true)
                {
                    List<string> listOfStrings = keys[i].ToCharArray().Select(x=> x.ToString()).ToList();
                    for (int k = 0; k < listOfStrings.Count; k++)
                    {
                        if (char.IsDigit(char.Parse(listOfStrings[k])))
                        {
                            listOfStrings[k] = (9 - int.Parse(listOfStrings[k])).ToString();
                        }
                    }
                    keys[i] = String.Join("", listOfStrings);
                    keys[i] = keys[i].ToUpper();
                    for (int j = 5; j < keys[i].Length; j += 6)
                    {
                        keys[i] = keys[i].Insert(j, "-");
                    }
                }
            }
            Console.WriteLine(String.Join(", ",keys));

        }
    }
}
