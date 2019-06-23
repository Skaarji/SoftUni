using System;
using System.Linq;

namespace encryptSortAndPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] codeArray = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                string name = Console.ReadLine();
                char[] nameArray = new char[name.Length];
                int code = 0;

                for (int j = 0; j < nameArray.Length; j++)
                {

                    nameArray[j] = name[j];
                    if (nameArray[j] == 'a'
                        || nameArray[j] == 'e'
                        || nameArray[j] == 'i'
                        || nameArray[j] == 'o'
                        || nameArray[j] == 'u'
                        || nameArray[j] == 'A'
                        || nameArray[j] == 'E'
                        || nameArray[j] == 'I'
                        || nameArray[j] == 'O'
                        || nameArray[j] == 'U')
                    {
                        code += nameArray[j] * name.Length;
                    }
                    else
                    {
                        code += nameArray[j] / name.Length;
                    }


                }
                codeArray[i] = code;
                
            }
            //Array.Sort(codeArray);
            codeArray= codeArray.OrderBy(a => a).ToArray();
            foreach (var item in codeArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}