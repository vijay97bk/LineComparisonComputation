using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonComputation
{
    class Line
    {
        public Point a;
        public Point b;
        public Line(Point aValue, Point bValue)
        {
            a = aValue;
            b = bValue;
        }
        public double CalculateLength()
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)); ;
        }
        public void Compare(Line l1)
        {
            if (l1.CalculateLength() == this.CalculateLength())
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }

        public void compareTo(Line l1)
        {
            double l1Length = l1.CalculateLength();
            double thisLineLength = this.CalculateLength();
            if (l1Length == thisLineLength)
                Console.WriteLine("Lines are equal");
            else if (l1Length > thisLineLength)
                Console.WriteLine("This line is smaller than Second Line");
            else
                Console.WriteLine("This line is greater than Second Line");
        }
    }
}
