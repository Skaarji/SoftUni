using System;
using System.Collections.Generic;
using System.Linq;

namespace validUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            List<string> namesSplit = names.Split(", ").ToList();
            for (int i = 0; i < namesSplit.Count; i++)
            {
                if (namesSplit[i].Length >= 3 && namesSplit[i].Length <= 16)
                {
                    bool isValid = true;

                    for (int j = 0; j < namesSplit[i].Length; j++)
                    {
                        char currentChar = namesSplit[i][j];
                        if (char.IsLetterOrDigit(currentChar) ||
                            currentChar == '-' ||
                            currentChar == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }

                    }
                    if (isValid==true)
                    {
                        Console.WriteLine(namesSplit[i]);
                    }

                }
            }
            
        }
    }
}
