﻿using System;

namespace LineComparision
{
   
    class Point
    {
        /// <summary>
        /// The x and y are two co-ordinates of a point
        /// They are initialised using a constructor
        /// </summary>
        public int x;
        public int y;
        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }
    }
    class Line
    {
        /// <summary>
        /// Line consists of two points a and b
        /// This class is used to compare
        /// </summary>
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

        public void Compare(Line l2)
        {
            if (l2.CalculateLength() == this.CalculateLength())
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }

        public void compareTo(Line l2)
        {
            double l1Length = l2.CalculateLength();
            double thisLineLength = this.CalculateLength();
            if (l1Length == thisLineLength)
                Console.WriteLine("Lines are equal");
            else if (l1Length > thisLineLength)
                Console.WriteLine("This line is smaller than Second Line");
            else
                Console.WriteLine("This line is greater than Second Line");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparision computation");

            Point a = new Point(3, 2);
            Point b = new Point(3, 5);
            Line l = new Line(a, b);

            Console.WriteLine("Length of line l: " + l.CalculateLength());

            Point a1 = new Point(3, 2);
            Point b1 = new Point(3, 5);
            Line l2 = new Line(a1, b1);

            Console.WriteLine("Length of line l1: " + l2.CalculateLength());
            l.Compare(l2);

            Point a3 = new Point(3, 2);
            Point b3 = new Point(3, 6);
            Line l3 = new Line(a3, b3);

            Console.WriteLine("Length of line l2: " + l3.CalculateLength());
            l.compareTo(l3);
        }
    }
}