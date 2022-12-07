using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_1_oop
{
    public class Rectangle
    {
        public double side1;
        public double side2;
        public double area;
        public double perimeter;
        public string choice1;
        public string choice2;
        public string rechangesides;

        double Area
        {
            get { return this.area; }
        }

        double Perimeter
        {
            get { return this.perimeter; }
        } 
        public Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

       public double AreaCalculator()
        {
            return this.area =  side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return this.perimeter =  (side1 * 2) + (side2 * 2);
        }

        public void ChoiceOne()
        {
            switch (this.choice1)
            {
                case "+":
                    PerimeterCalculator();
                    PrintPerimeter();
                    break;
                case "-":
                    Console.WriteLine("Шкода!! А ми так для вас старались(");
                    break;
                default:
                    Console.WriteLine("Ви не ввели + або -, тому зроблю вигляд, що я цього не помiтив)");
                    break;
            }
        }

        public void ChoiceTwo()
        {
            switch (this.choice2)
            {
                case "+":
                    AreaCalculator();
                    PrintArea();
                    break;
                case "-":
                    Console.WriteLine("Шкода!! А ми так для вас старались(");
                    break;
                default:
                    Console.WriteLine("Ви не ввели + або -, тому зроблю вигляд, що я цього не помiтив)");
                    break;
            }
        }
        public void RechangeSides()
        {
            switch (this.rechangesides)
            {
                case "+":
                    break;
                case "-":
                    PerimeterCalculator();
                    PrintPerimeter();
                    AreaCalculator();
                    PrintArea();
                    break;
                default:
                    Console.WriteLine("Ви не ввели + або -, тому комп'ютер це побачив як + ))))");
                    break;
            }
        }

        public void DoubleCheckOne()
        {
            do
            {
               
            }
            while (!double.TryParse(Console.ReadLine(), out this.side1) || this.side1<0);
        }
        public void DoubleCheckTwo()
        {
            do
            {
               
            }
            while (!double.TryParse(Console.ReadLine(), out this.side2) || this.side2<0);
        }

               public void PrintArea()
        {
            Console.WriteLine($"Площа дорiвнює {Area} см");
        }
        public void PrintPerimeter()
        {
            Console.WriteLine($"Периметр дорiвнює {Perimeter} см");
        }
    }
}
