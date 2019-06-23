using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ragequit2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder sb = new StringBuilder();
            StringBuilder toRepeat = new StringBuilder();


            for (int i = 0; i < input.Length; i++)
            {



                if (!char.IsNumber(input[i]))
                {
                    toRepeat.Append(input[i]);
                }
                else
                {
                    int repeats = 0;

                    if (i == input.Length - 1)
                    {
                        repeats = int.Parse(input[i].ToString());
                    }
                    else 
                    {
                        if (char.IsNumber(input[i + 1])==false)
                        {
                            repeats = int.Parse(input[i].ToString());
                        }
                        else if (char.IsNumber(input[i + 1]))
                        {
                            repeats = int.Parse(input[i] + input[i + 1].ToString());
                            i++;
                        }
                    }
                    for (int j = 0; j < repeats; j++)
                    {
                        sb.Append(toRepeat);
                    }
                    toRepeat.Clear();
                }

            }
            var count = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");

            Console.WriteLine(sb);

        }

    }
}

