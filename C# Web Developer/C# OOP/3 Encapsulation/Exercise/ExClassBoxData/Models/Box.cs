using System;
using ExClassBoxData.Exceptions;

namespace ExClassBoxData.Models

{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException(ExceptionMessages.LengthZeroOrNegativeException);
                }
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.WidthZeroOrNegativeException);
                }
                width = value;

            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.HeightZeroOrNegativeException);
                }
                height = value;

            }
        }

        public Box(double length, double width, double height)
        {
            Length = length;
            Height = height;
            Width = width;                
        }

        public void Volume()
        {
            double volume = this.Height * this.Length * this.Width;
            Console.WriteLine($"Volume - {volume:f2}");
        }
        public void SurfaceArea()
        {
            double surfaceArea = (2*Length*Width)+(2*Length*Height)+(2*Width*Height);
            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        }
        public void LateralSurfaceArea()
        {
            double lateral = (2 * Length * Height) + (2 * Width * Height);
            Console.WriteLine($"Lateral Surface Area - {lateral:f2}");
        }
    }
}
