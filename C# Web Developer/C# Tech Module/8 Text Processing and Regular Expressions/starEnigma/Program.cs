using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace starEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<string> destroyed = new List<string>();
            List<string> attacked = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string codedLine = Console.ReadLine();

                var matches = Regex.Matches(codedLine, @"[STARstar]");

                int key = matches.Count;

                char[] decyphered = codedLine.ToCharArray();

                for (int j = 0; j < decyphered.Length; j++)
                {
                    decyphered[j] -= (char)key;
                }
                string decypheredToString = String.Join("", decyphered);

                var planet = Regex.IsMatch(decypheredToString, @"[@]([A-Z]{1}[a-z]{1,})");
                var population = Regex.IsMatch(decypheredToString, @":([0-9]{1,})");
                var attackType = Regex.IsMatch(decypheredToString, @"!([DA])!");
                var Soldiers = Regex.IsMatch(decypheredToString, @"->([0-9]{1,})");


                if (planet == true && population == true && attackType == true & Soldiers == true)
                {
                    var lineMatches = Regex.Match(decypheredToString, @"([^@:!\->]*)@([A-Za-z]+)([^@:!\->]*):([0-9]+)([^@:!\->]*)!([AD])!([^@:!\->]*)->([0-9]+)([^@:!\->]*)");

                    string attType = lineMatches.Groups[6].ToString();
                    string planetNam = lineMatches.Groups[2].ToString();
                    if ( attType == "D")
                    {
                        destroyed.Add(planetNam);
                    }
                    else if (attType=="A")
                    {
                        attacked.Add(planetNam);
                    }
                }
            }
            attacked.Sort();
            destroyed.Sort();
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var item in attacked)
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var item in destroyed)
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
