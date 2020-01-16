using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly : InternalsVisibleTo("CSharp4-3")]

namespace CSharp4_2
{
    abstract class Polygon
    {
        abstract public double area();
    }
}
