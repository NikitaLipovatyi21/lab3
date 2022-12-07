using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_3_oop
{
    internal class Figure : Point
    {
        public Point A;
        public Point B;
        public Point C;
        public Point D;
        public Point E;
        private int choice;
        public Figure(double x, double y, string name) : base(x, y, name)
        {
            
        }
        public Figure(Point A, Point B, Point C) : base (0,0,"")
        {
            this.name = "Трикутник";
            A = this.A;
            B = this.B;
            C = this.C;
        }
        public Figure(Point A, Point B, Point C,Point D) : base(0, 0, "")
        {
            this.name = "Квадрат";
            A = this.A;
            B = this.B;
            C = this.C;
            D = this.D;
        }
        public Figure(Point A, Point B, Point C, Point D,Point E) : base(0, 0, "")
        {
            this.name = "П'ятикутник";
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;

        }

       public double LengthSide(Point A,Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));    
        }

        public void PerimeterCalculatorTriangle()
        {
            double perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A);
            Console.WriteLine($"Периметр дорiвнює : {perimeter} од.в.");
        }

        public void PerimeterCalculatorRectangle()
        {
            double perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D,A) ;
            Console.WriteLine($"Периметр дорiвнює : {perimeter} од.в.");
        }
        public void PerimeterCalculatorPentagon()
        {
            double perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
            Console.WriteLine($"Периметр дорiвнює : {perimeter} од.в.");
        }
        public void SelectFigure()
        {
            
            switch (this.choice)
            {
                case 1:
                    PerimeterCalculatorTriangle();
                    break;
                case 2:
                    PerimeterCalculatorRectangle();
                    break;
                case 3:
                    PerimeterCalculatorPentagon();
                    break;
                default:
                    Console.WriteLine("Щось не то...");
                    break;
            }
        }

            public void Check()
            {
                do
                {
                   
                }
                while (!int.TryParse(Console.ReadLine(), out this.choice) ||this.choice>3 || this.choice<1);
            }
    }
}
