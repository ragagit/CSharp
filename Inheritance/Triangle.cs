using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4_2
{
    class Triangle : Polygon
    {
        public double tbase, height;

        public Triangle(double t, double h)
        {
            tbase = t;
            height = h;
        }

        public override double area()
        {
            return tbase * height / 2;
        }
    }
}
