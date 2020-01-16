using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS5_5
{
    public class Integer
    {
        public int value { get; set; }

        public Integer(int x)
        {
            value = x;
        }
        
        public void print(){
            Console.WriteLine("Integer value = {0}", value);
        }
         
    }
    public static class IntegerExtender
    {
        public static void Square(this Integer x)
        {
            x.value *= x.value;
        }
        public static void print(this Integer x)
        {
            //Console.WriteLine("(Extension)Integer value = {0}", x.value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Integer i = new Integer(5);
            i.Square();
            //Console.WriteLine(i.value);
            i.print();
        }
    }
}
