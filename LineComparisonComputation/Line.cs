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

    }
}
