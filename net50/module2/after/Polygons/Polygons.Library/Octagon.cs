using System;

namespace Polygons.Library
{
    public class Octagon : Object, IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
