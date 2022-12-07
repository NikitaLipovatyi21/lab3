using System;

namespace lab_3_3_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(3, 5, "A");
            Point B = new Point(-10, 6, "B");
            Point C = new Point(7, -3, "C");
            Point D = new Point(12, 8, "D");
            Point E = new Point(5, -5, "B");
            Figure figure = new Figure(A, B, C,D,E);
            Console.WriteLine("Оберiть один iз видiв багатокутника(вiд 1 до 3):");
            Console.WriteLine("1.Трикутник");
            Console.WriteLine("2.Квадрат");
            Console.WriteLine("3.П'ятикутник");
            figure.Check();
            figure.SelectFigure();
            Console.ReadKey();

        }
    }
}
