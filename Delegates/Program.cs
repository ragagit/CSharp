using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Delegates
A delegate is a type that represents references to the methods with a particular parameters list and return type.
Delegates are used to pass methods as arguments to other methods.
Delegates are like C++ function pointers but are type safe
Delegates allow methods to be passed as parameters
Delegates can be used to define callback methods
Delegates can be chained together
Methods do not have to match the delegate type exactly.

Multicast delegates can be createwd by using the +,-,+=,-= operators

Instance Methods
When a delegate is constructed to wrap an instance method, the delegate
references both the instance and the method. Delegate can refer to any method
as long as it matches the delegate signature.

Generic Delegates
delegate T Transformer<T>(T x);
Transformer<int> t = Square;

Action Delegate
    It returns void

Func
    It returns a value
    Cna point to amethid that returns up to 16 params

Compatibility
    Delegate types are all incompatible with each other, even if their signature
    are the sane.
    delegate int Trans(int x);
    delegate int Trans2(int x);
    static void Main(string[] args){
        Trans t1 = Square;
        Trans2 t2 = t1 //error
    }
Equality
    They are equal if they refer to the same method
    
*/

namespace CSharp5_1
{
    class Program
    {
        delegate double FuncDel(double x);
        delegate void FuncPrint<T,U>(T x, U y);
        static void Main(string[] args)
        {
            FuncDel f1 = Func1;

            Console.WriteLine(f1(5));

            f1 += Func2;

            Console.WriteLine(f1(5));

            processFunc(4.5, f1);

            FuncPrint<double, FuncDel> printDel = processFunc;

            printDel += processFunc2;

            printDel(6.5, f1);

            Func<double, double> f2 = Func2;
            f2 += Func1;

            Console.WriteLine(f2(3));
        }
        static double Func1(double x)
        {
            Console.WriteLine("Func1");
            return x * x + 1;
        }

        static double Func2(double x)
        {
            return 3 * x + 8;
        }

        static void processFunc(double x, FuncDel f)
        {
            Console.WriteLine(f(x));
        }
        static void processFunc2(double x, FuncDel f)
        {
            Console.WriteLine(f(x));
            Console.WriteLine(f(x+1));
        }
    }
}
