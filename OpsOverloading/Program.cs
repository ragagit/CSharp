using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS5_4
{
    class Digit
    {
        double value;
        public Digit(double d)
        {
            value = d;
        }

        public static Digit operator +(Digit d1, Digit d2)
        {
            return new Digit(d1.value + d2.value);
        }
        public static Digit operator +(Digit d1, double d2)
        {
            return new Digit(d1.value + d2);
        }
        public override string ToString()
        {
            return value.ToString();
        }
        public static bool operator ==(Digit d1, Digit d2)
        {
            return (d1.value == d2.value);
        }
        public static bool operator !=(Digit d1, Digit d2)
        {
            return (d1.value != d2.value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Digit d1 = new Digit(2);

            d1 = d1 + d1;

            d1+= 4;

            Console.WriteLine(d1);

            Digit d2 = new Digit(8);

            Console.WriteLine(d1 == d2);
        }
    }
}
