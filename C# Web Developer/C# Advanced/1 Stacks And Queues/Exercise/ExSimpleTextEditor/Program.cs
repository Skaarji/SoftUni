using System;
using System.Collections.Generic;
using System.Text;

namespace ExSimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;

            int numberOfCommands = int.Parse(Console.ReadLine());
            //StringBuilder sb = new StringBuilder();

            Stack<string> textStates = new Stack<string>();  
            for (int i = 0; i < numberOfCommands; i++)
            {
                
                string input = Console.ReadLine();
                string[] command = input.Split();
                int type = int.Parse(command[0]);

                if (type == 1)
                {
                    textStates.Push(text);
                    text += command[1];                    
                }
                else if (type == 2)
                {
                    textStates.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(command[1]));
                    //Queue<char> textInChar= new Queue<char>(text.ToCharArray());
                    //for (int j = 0; j < int.Parse(command[1]); j++)
                    //{
                    //    textInChar.Dequeue();
                    //}
                    //text = string.Join("", textInChar);
                }
                else if (type == 3)
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (type== 4)
                {
                    text = textStates.Pop();
                }
            }

        }
    }
}
