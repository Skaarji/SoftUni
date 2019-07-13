using System;
using System.Linq;

namespace countUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(Upper)
                //.Where(x => char.IsUpper(x[0]))
                .ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }               
            
            
        }

        public static Func<string, bool> Upper = n =>
        {
            bool result = false;
            if (n[0] > 64 && n[0]< 90)
            {
                result = true;
                return result;
            }
            return result;

        };
    }
}
