using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4_5
{
    class Rectangle : Polygon, Printable
    {
        double width, height;

        double Polygon.area()
        {
            return width * height;
        }

        double Printable.area()
        {
            return (width + 2) * (height + 2);
        }

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
    }
}
