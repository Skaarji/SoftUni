using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace songEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> commandSplit = command.Split(":").ToList();
                bool Artists = Regex.IsMatch(commandSplit[0], @"^[A-Z][a-z' ]*$");
                bool Song = Regex.IsMatch(commandSplit[1], @"^[A-Z ]+$");

                if (Artists == true && Song == true)
                {
                    int key = commandSplit[0].Length;

                    char[] charArtist = commandSplit[0].ToCharArray();
                    char[] charSong = commandSplit[1].ToCharArray();


                    for (int i = 0; i < charArtist.Length; i++)
                    {

                        if (charArtist[i] == ' ' || charArtist[i] == '\'')
                        {
                            continue;
                        }

                        else if (charArtist[i] <= 90 && charArtist[i] + key > 90)
                        {
                            charArtist[i] = (char)(64 + (charArtist[i] + key - 90));
                        }
                        else if (charArtist[i] <= 122 && charArtist[i] + key > 122)
                        {
                            charArtist[i] = (char)(96 + (charArtist[i] + key - 122));
                        }
                        else
                        {
                            charArtist[i] = (char)(charArtist[i] + key);
                        }
                    }
                    for (int i = 0; i < charSong.Length; i++)
                    {
                        if (charSong[i] == ' ' || charSong[i] == '\'')
                        {
                            continue;
                        }
                        if (charSong[i] <= 90 && charSong[i] + key > 90)
                        {
                            charSong[i] = (char)(64 + (charSong[i] + key - 90));
                        }
                        else if (charSong[i] <= 122 && charSong[i] + key > 122)
                        {
                            charSong[i] = (char)(96 + (charSong[i] + key - 122));
                        }
                        else
                        {
                            charSong[i] = (char)(charSong[i] + key);
                        }

                    }

                    Console.WriteLine($"Successful encryption: {string.Join("", charArtist)}@{string.Join("", charSong)}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }
        }
    }
}
