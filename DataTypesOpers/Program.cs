using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 1;

            Console.WriteLine("int: " + one);

            float onepointone = 1.1f;

            Console.WriteLine("float: " + onepointone);

            double onepointone2 = 1.1;

            Console.WriteLine("double: " + onepointone2);

            int two = 5 / 2;

            Console.WriteLine("5/2 (1st Attempt): " + two);

            float twopointfive = 5.0f / 2;

            Console.WriteLine("5/2 (2nd Attempt): " + twopointfive);

            string eduonix = "\"Eduonix\"";

            Console.WriteLine(eduonix);

            string eduonix2 = @"Eduonix\\n";

            Console.WriteLine(eduonix2);

            decimal dec = 1.2m;

            Console.WriteLine("decimal: " + dec);

            int x = 4, y = 8;

            Console.WriteLine("Addition: " + (x + y));

            Console.WriteLine("Multiplication: " + (x * y));

            Console.WriteLine("Division: " + (y / x));

            Console.WriteLine("Mod: " + (5 % 2));

            Console.WriteLine("++x: " + ++x);

            Console.WriteLine("y--: " + y--);

            Console.WriteLine("y is now: " + y);

            bool test;

            test = 1 > 2;

            Console.WriteLine("1>2: " + test);

            Console.WriteLine("1<2: " + (1<2));

            Console.WriteLine("x = 2: " + (x == 2));

            Console.WriteLine("x != 2: " + (x != 2));
        }
    }
}
