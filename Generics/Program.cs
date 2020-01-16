using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Generics
Type parameters make it possible to design classes and methods that defer the specification of one or more types until the class
Or method is declared and instantiated by client code.
Technically, we say that Stack<T> is an open type, whereas Stack<int> is a closed type.
One issue with generics is how to assign default values before knowing if it is a reference or a value type. To solve it we use
Default keyword which will return null for reference types and zero for numeric value types.
*/
namespace CSharpS4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Shuffler<int> shuff = new Shuffler<int>();
            shuff.add(5);
            shuff.add(6);
            shuff.add(7);
            shuff.add(8);
            shuff.add(9);
            shuff.add(10);
            shuff.shuffle();
            shuff.print();

            Shuffler<string> shuff2 = new Shuffler<string>();
            shuff2.add("string1");
            shuff2.add("string2");
            shuff2.add("string3");
            shuff2.add("string4");
            shuff2.add("string5");
            shuff2.add("string6");
            shuff2.shuffle();
            shuff2.print();

            int x = 15;
            int y = 20;

            Shuffler<int>.swap(ref x, ref y);

            Console.WriteLine(y);
        }
    }

    class Shuffler<T>
    {
        T[] list = new T[100];
        int pos = 0;
        Random rnd = new Random();

        public void add(T t)
        {
            list[pos++] = t;
        }

        public void shuffle()
        {
            for (int i = 0; i < pos; i++)
            {
                swap(ref list[i], ref list[rnd.Next(0, pos - 1)]);
            }
        }
        public static void swap<T>(ref T t1,ref  T t2)
        {
            T temp;
            temp = t2;
            t2 = t1;
            t1 = temp;
        }
        public void print()
        {
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine("Element at " + i + ": " + list[i]);
            }
        }
    }
}
