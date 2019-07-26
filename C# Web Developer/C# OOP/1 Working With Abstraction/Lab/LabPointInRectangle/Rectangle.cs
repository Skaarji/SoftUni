using System;
using System.Collections.Generic;
using System.Text;

namespace LabPointInRectangle
{
    class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topleft, Point bottomright)
        {
            TopLeft = topleft;
            BottomRight = bottomright;
        }

        public bool Contains(Point point)
        {
            bool insideByX = point.CoordinateX >= TopLeft.CoordinateX && point.CoordinateX <= BottomRight.CoordinateX;
            bool insideByY = point.CoordinateY >= TopLeft.CoordinateY && point.CoordinateY <= BottomRight.CoordinateY;

            return insideByX && insideByY;
        }

    }
}
