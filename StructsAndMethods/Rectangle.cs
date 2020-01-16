using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4_2
{
    class Rectangle : Polygon
    {
        protected double height, width;
        public Rectangle()
        {

        }
        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }

        public override double area()
        {
            return height * width;
        }
    }
}
