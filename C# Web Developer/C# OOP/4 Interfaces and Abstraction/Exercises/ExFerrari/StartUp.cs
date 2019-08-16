using ExFerrari.Interfaces;
using ExFerrari.Models;
using System;

namespace ExFerrari
{
   public class StartUp

    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            IFerrari ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari.ToString()); 
        }
    }
}
