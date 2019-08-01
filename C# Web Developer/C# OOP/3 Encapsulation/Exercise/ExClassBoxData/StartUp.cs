using System;
using ExClassBoxData.Models;

namespace ExClassBoxData
{
    public class StartUp
    {
        
        static void Main(string[] args)
        {

            try
            {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);
            
            box.SurfaceArea();
            box.LateralSurfaceArea();
            box.Volume();

            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

        }
    }
}
