using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to line comparision computation");
            Point a = new Point(3, 2);
            Point b = new Point(3, 5);
            Line l = new Line(a, b);
            Console.WriteLine("Length of line l: " + l.CalculateLength());

            Point a1 = new Point(3, 2);
            Point b1 = new Point(3, 5);
            Line l1 = new Line(a1, b1);

            Console.WriteLine("Length of line l1: " + l1.CalculateLength());
            l.Compare(l1);

            Point a2 = new Point(3, 2);
            Point b2 = new Point(3, 6);
            Line l2 = new Line(a2, b2);

            Console.WriteLine("Length of line l2: " + l2.CalculateLength());
            l.compareTo(l2);
        }
    }
}
