using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4_5
{
    //This Flag indicates that an enumeration can be treated as a bit field
    //i.e. a set of flags
    [Flags]
    enum Days { Sat = 1, Sun=2, Mon=4, Tue=8, Wed=16, Thu=32, Fri=64 };


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5, 8);
            Days days = Days.Sat | Days.Sun | Days.Wed;
            Console.WriteLine(days);
            PolygonPrint(r1);
            PrintableArea(r1);
        }

        public static void PolygonPrint(Polygon p)
        {
            Console.WriteLine("Area:" + p.area());
        }

        public static void PrintableArea(Printable p)
        {
            Console.WriteLine("Minimum Area to print: " + p.area());
        }
    }
}
