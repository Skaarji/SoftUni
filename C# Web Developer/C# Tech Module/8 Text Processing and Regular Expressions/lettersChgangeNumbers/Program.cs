using System;
using System.Text.RegularExpressions;

namespace lettersChgangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, @"[A-Za-z]{1}\d{1,}[A-Za-z]");

            double sum = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                string currentString = matches[i].ToString();
                double number = double.Parse(currentString.Substring(1, currentString.Length - 2));
                string first = currentString[0].ToString();
                double letterPosition = LetterPosition(first);
                bool upper = UpperOrLower(first);

                if (upper==true)
                {
                    number /= letterPosition;
                }
                else
                {
                    number *= letterPosition;
                }
                string second = currentString[currentString.Length - 1].ToString();
                letterPosition = LetterPosition(second);
                upper = UpperOrLower(second);
                if (upper == true)
                {
                    number -= letterPosition;
                }
                else
                {
                    number += letterPosition;
                }
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");

        }

        private static bool UpperOrLower(string letter)
        {
            bool upper = false;
            if (char.Parse(letter) >= 65 && char.Parse(letter) <= 90)
            {
                upper = true;
            }

            return upper;
        }

        private static int LetterPosition(string letter)
        {
            bool upper = UpperOrLower(letter);
            if (char.Parse(letter) >= 65 && char.Parse(letter) <= 90)
            {
                upper = true;
            }
            int position = 0;

            if (upper==true)
            {
                return position = char.Parse(letter) - 65 + 1;
            }
            else
            {
                return position = char.Parse(letter) - 97 + 1;
            }


        }
    }
}
