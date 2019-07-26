using System;
using System.Linq;

namespace LabPointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = ParseInput();
            int numberOfLines = int.Parse(Console.ReadLine());

            Point topLeft = new Point(coordinates[0], coordinates[1]);
            Point bottomRight = new Point(coordinates[2], coordinates[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);


            for (int i = 0; i < numberOfLines; i++)
            {
                int[] point = ParseInput();

                Point currentPoint = new Point(point[0], point[1]);

                Console.WriteLine(rectangle.Contains(currentPoint));
            }


        }

        private static int[] ParseInput()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
