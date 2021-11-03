using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение стороны А: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение стороны B: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(side1, side2);

            Console.Write("\nПлощадь прямоугольника: " + myRectangle.Area);
            Console.Write("\nПериметр прямоугольника: " + myRectangle.Perimeter);
        }
    }
}
