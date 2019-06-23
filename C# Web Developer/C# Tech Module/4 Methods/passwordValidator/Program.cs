using System;

namespace passwordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Boolean isValid1, isValid2, isValid3 = isValid2 = isValid1 = true;

            isValid1 = stringLenght(input, isValid1);

            isValid2 = letterOrNumber(input, isValid2);

            isValid3 = atLeast2Digits(input, isValid3);

            if (isValid1 == true && isValid2 == true && isValid3 == true)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool atLeast2Digits(string input, bool isValid3)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                isValid3 = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            return isValid3;
        }

        private static bool letterOrNumber(string input, bool isValid2)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57 || input[i] >= 97 && input[i] <= 122 || input[i] >= 65 && input[i] <= 90)
                {

                }
                else
                {
                    isValid2 = false;

                }
            }
            if (isValid2 == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            return isValid2;
        }

        private static bool stringLenght(string input, bool isValid1)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                isValid1 = false;
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }

            return isValid1;
        }
    }
}
