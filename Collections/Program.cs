using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpS59
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ilist = new List<int>();
            ilist.Add(10);
            ilist.Add(7);
            ilist.Add(15);
            ilist.Add(3);

            foreach (int i in ilist)
                Console.WriteLine(i);

            ilist.Sort();
            Console.WriteLine("Sorted List:");
            foreach (int i in ilist)
                Console.WriteLine(i);

            LinkedList<int> llist = new LinkedList<int>();

            llist.AddLast(10);
            llist.AddLast(15);
            llist.AddLast(20);

            LinkedListNode<int> middle = llist.Find(15);

            llist.AddAfter(middle, 18);

            foreach(int i in llist)
                Console.WriteLine(i);

            Console.WriteLine("Queue:");

            Queue<int> q1 = new Queue<int>();

            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);

            while (q1.Count > 0)
            {
                Console.WriteLine(q1.Dequeue());
            }

            Console.WriteLine("Stack");

            Stack<int> s1 = new Stack<int>();

            s1.Push(1);
            s1.Push(2);
            s1.Push(3);

            while(s1.Count > 0){
                Console.WriteLine(s1.Pop());
            }

            BitArray ba = new BitArray(5, true);

            ba.Set(2, false);

            foreach (bool b in ba)
                Console.WriteLine(b);

            BitArray ba2 = new BitArray(5, true);

            ba2.Set(0, false);
            ba2.Set(1, false);

            Console.WriteLine("And BitArray:");

            ba.And(ba2);

            foreach (bool b in ba)
                Console.WriteLine(b);

            HashSet<string> hs = new HashSet<string>();

            hs.Add("String1");
            hs.Add("String2");
            hs.Add("String3");
            hs.Add("String4");
            hs.Add("String5");
            hs.Add("String5");

            foreach (string s in hs)
                Console.WriteLine(s);
        }
    }
}
