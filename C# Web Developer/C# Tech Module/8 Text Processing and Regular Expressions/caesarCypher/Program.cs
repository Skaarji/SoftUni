using System;
using System.Text;

namespace caesarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //foreach (var item in collection)
            //{

            //}


            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(arr[i]+ 3); 
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }





        }
    }
}
