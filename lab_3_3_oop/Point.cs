using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_3_oop
{
    class Point
    {
        public double x;
        public double  y;
        public string name;

       public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

         public Point(double x,double y,string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
