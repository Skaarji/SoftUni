using System;

namespace balancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            bool Balanced = true;

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                char ValueChar;
                char.TryParse(input, out ValueChar);
                if (ValueChar == '(')
                {
                    counter1++;
                    if (counter1 >1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                if (ValueChar == ')')
                {
                    counter2++;
                    if (counter1 !=1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    else
                    {
                        counter1 = 0;
                        counter2 = 0;
                    }
                }

            }
            if (counter1 == counter2)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
