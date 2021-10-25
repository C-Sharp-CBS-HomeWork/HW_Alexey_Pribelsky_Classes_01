using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Rectangle
    {
        private double A, B, perimeter = 0, area = 0;

        public Rectangle(double side1, double side2)
        {
            this.A = side1;
            this.B = side2;
            area = AreaCalculator(A, B);
            perimeter = PerimeterCalculator(A, B);
        }
        double AreaCalculator(double A, double B)
        {
            area = A * B;
            return area;
        }
        double PerimeterCalculator(double A, double B)
        {
            perimeter = 2 * (A + B);
            return perimeter;
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
    }
}
