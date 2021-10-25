using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор сторон многоугольника";
            int A1, A2, B1, B2, C1, C2, D1, D2, E1, E2;

            Console.Write("Введите координату X стороны А: ");
            A1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y стороны А: ");
            A2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X стороны B: ");
            B1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y стороны B: ");
            B2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X стороны C: ");
            C1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y стороны C: ");
            C2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X стороны D: ");
            D1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y стороны D: ");
            D2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X стороны E: ");
            E1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y стороны E: ");
            E2 = int.Parse(Console.ReadLine());

            Point A = new Point(A1, A2, "A");
            Point B = new Point(B1, B2, "B");
            Point C = new Point(C1, C2, "C");
            Point D = new Point(D1, D2, "D");
            Point E = new Point(E1, E2, "E");


            Figure triangle = new Figure(A, B, C);
            Console.WriteLine($"\nБуквенное наименование фигуры: {triangle.Name}");
            Console.WriteLine($"Периметр фигуры треугольник: {triangle.Perimeter}");

            Figure square = new Figure(A, B, C, D);
            Console.WriteLine($"Буквенное наименование фигуры: {square.Name}");
            Console.WriteLine($"Периметр фигуры четырехугольник: {square.Perimeter}");

            Figure pentagon = new Figure(A, B, C, D, E);
            Console.WriteLine($"Буквенное наименование фигуры: {pentagon.Name}");
            Console.WriteLine($"Периметр фигуры пятиугольник: {pentagon.Perimeter}");
        }
    }
}
