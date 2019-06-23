using System;
using System.Collections.Generic;
using System.Linq;

namespace stringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToList();
            int explosionSize = 0;
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i] == ">")
                {
                    explosionSize += int.Parse(text[i + 1]);
                    int currentExplosionSize = explosionSize;

                    for (int j = 0; j < currentExplosionSize; j++)
                    {
                        if (i + 1 > text.Count - 1)
                        {
                            Console.WriteLine(String.Join("", text));
                            return;
                        }

                        if (text[i + 1] != ">")
                        {
                            text.RemoveAt(i + 1);
                            explosionSize--;
                        }
                        else if (text[i + 1] == ">")
                        {

                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join("", text));
        }
    }
}
