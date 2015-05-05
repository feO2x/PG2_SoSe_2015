using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public struct Point : IEquatable<Point>
    {
        public double X;
        public double Y;

        //public Point() Kein Standardkonstruktor in Strukturen
        //{

        //}

        public Point(double x, double y) 
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("Point: {0}, {1}", X, Y);
        }

        public bool Equals(Point other)
        {
            return other.X == X &&
                   other.Y == Y;
        }
    }
}
