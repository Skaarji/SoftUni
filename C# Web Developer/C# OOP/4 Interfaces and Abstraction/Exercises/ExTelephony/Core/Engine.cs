using ExTelephony.Exceptions;
using ExTelephony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExTelephony.Core
{
    public class Engine
    {
        private Smartphone smartphone;
        public Engine()
        {
            this.smartphone = new Smartphone();
        }
        public void Run()
        {
            string[] numbers = Console.ReadLine().Split(" ").ToArray();
            string[] urls = Console.ReadLine().Split(" ").ToArray();

            CallNumbers(numbers);
            BrowseSites(urls);
        }

        private void BrowseSites(string[] urls)
        {
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Browse(url));
                }
                catch (InvalidURL e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }
        }

        private void CallNumbers(string[] numbers)
        {
            foreach (var number in numbers)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Call(number));
                }
                catch (InvalidNumber e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
