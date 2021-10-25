using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class Figure
    {
        string name;
        Point[] points;

        public Figure(Point A, Point B, Point C)
        {
            name = A.Name + B.Name + C.Name;
            points = new Point[3] { A, B, C };
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            name = A.Name + B.Name + C.Name + D.Name;
            points = new Point[4] { A, B, C, D };
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            name = A.Name + B.Name + C.Name + D.Name + E.Name;
            points = new Point[5] { A, B, C, D, E };
        }


        public double SideLength(Point A, Point B)
        {
            double length = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));

            return length;
        }
        public double Perimeter
        {
            get
            {
                double perimeter = 0;
                for (int i = 1; i < points.Length; i++)
                {
                    perimeter += SideLength(points[i - 1], points[i]);
                }
                perimeter += SideLength(points[0], points[points.Length - 1]);
                return perimeter;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

    }
}
