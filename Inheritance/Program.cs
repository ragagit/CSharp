using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Public Access is not restricted
protected access is limited to the containing class or types derived from that class
Internal Access to the current assembly
Protected internal combination of protected and internal
Private access is limited to the containing type.
Interfaces are public
Struct the default is private with public and internal supported as well
 */
namespace CSharp4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2, 3);
            Triangle t1 = new Triangle(2, 3);
            Square s1 = new Square(2);

            //r1.width = 10;

            t1.height = 10;

            Polygon[] shapes = new Polygon[3];

            shapes[0] = r1;
            shapes[1] = t1;
            shapes[2] = s1;

            foreach (Polygon p in shapes)
            {
                Console.WriteLine("Area: " + p.area());
            }

            Triangle t2 = (Triangle)shapes[1];
            Rectangle r2 = shapes[0] as Rectangle;
            if (r2 != null)
            {
                Console.WriteLine(r2.area());
            }
        }
    }
}
