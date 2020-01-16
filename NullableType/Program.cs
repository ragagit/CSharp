using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Nullable types
Reference types can represent a non existing value with a null reference. Value types
Cannot represent null values. To represent it you need to use a special construct called a nullable
type
int? x = null

Conversion from a type to a nullable type is implicit
int? y = null;
int x = 5;
y=x;

Conversion from a nullable type to a regular type needs to be explicit
int? Y = null;
int x = 5;
x = (int)y;

Null Coalescing Operator
The ?? Operator is called the null-coalescing operator. It returns
The left-hand operand  if the operand is not null; otherwise it returns the right hand operand
int? x = null;
int I=x??-1
 */
namespace CSharpS4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? z = 15;

            if (x.HasValue)
            {
                Console.WriteLine("X = " + x);
            }

            int y = x.GetValueOrDefault();

            Console.WriteLine("Y = " + y);

            y = x ?? z ?? 10;

            Console.WriteLine("Y = " + y);
        }
    }
}
